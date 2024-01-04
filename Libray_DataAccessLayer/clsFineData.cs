using Library_Utility;
using Libray_DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Library_DataAccessLayer
{
    public class clsFineData
    {
        public static bool GetFineInfoByID(int? FineID, ref int? MemberID, ref int? BorrowingRecordID, ref short? NumberOfLateDays, ref double? FineAmount, ref bool? PaymentStatus, ref int? CreatedByUserID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * 
                            FROM Fines 
                            WHERE FineID = @FineID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineID", (object)FineID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                IsFound = true;

                                MemberID = (reader["MemberID"] != DBNull.Value) ? (int?)reader["MemberID"] : null;

                                BorrowingRecordID = (reader["BorrowingRecordID"] != DBNull.Value) ? (int?)reader["BorrowingRecordID"] : null;

                                NumberOfLateDays = (reader["NumberOfLateDays"] != DBNull.Value) ? (short?)reader["NumberOfLateDays"] : null;

                                FineAmount = (reader["FineAmount"] != DBNull.Value) ? (double?)reader["FineAmount"] : null;

                                PaymentStatus = (reader["PaymentStatus"] != DBNull.Value) ? (bool?)reader["PaymentStatus"] : null;

                                CreatedByUserID = (reader["CreatedByUserID"] != DBNull.Value) ? (int?)reader["CreatedByUserID"] : null;

                            }

                            else
                            {
                                // The record wasn't found !
                                IsFound = false;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                IsFound = false;
            }
            return IsFound;
        }

        public static bool IsFineExist(int? FineID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT IsFound = 1 
                             FROM Fines
                             WHERE FineID = @FineID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FineID", (object)FineID ?? DBNull.Value);

                        object reader = command.ExecuteScalar();

                        IsFound = (reader != null);
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                IsFound = false;
            }
            return IsFound;
        }

        public static int? AddNewFine(int? MemberID, int? BorrowingRecordID, short? NumberOfLateDays, double? FineAmount, bool? PaymentStatus, int? CreatedByUserID)
        {
            int? FineID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Fines (MemberID,BorrowingRecordID,NumberOfLateDays,FineAmount,PaymentStatus,CreatedByUserID)
                            VALUES (@MemberID,@BorrowingRecordID,@NumberOfLateDays,@FineAmount,@PaymentStatus,@CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BorrowingRecordID", (object)BorrowingRecordID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NumberOfLateDays", (object)NumberOfLateDays ?? DBNull.Value);
                        command.Parameters.AddWithValue("@FineAmount", (object)FineAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PaymentStatus", (object)PaymentStatus ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", (object)CreatedByUserID ?? DBNull.Value);

                        object InsertedRowID = command.ExecuteScalar();

                        //Check if the new FineID was successfully inserted
                        if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                        {
                            FineID = InsertedID;
                        }

                        // Set FineID to null to indicate failure
                        else
                            FineID = null;

                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                FineID = null;
            }
            return FineID;
        }

        public static bool UpdateFineInfo(int? FineID, int? MemberID, int? BorrowingRecordID, short? NumberOfLateDays, double? FineAmount, bool? PaymentStatus, int? CreatedByUserID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Fines
                            SET 
							MemberID = @MemberID,
							BorrowingRecordID = @BorrowingRecordID,
							NumberOfLateDays = @NumberOfLateDays,
							FineAmount = @FineAmount,
							PaymentStatus = @PaymentStatus,
							CreatedByUserID = @CreatedByUserID
                            WHERE FineID = @FineID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@FineID", (object)FineID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BorrowingRecordID", (object)BorrowingRecordID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NumberOfLateDays", (object)NumberOfLateDays ?? DBNull.Value);
                        command.Parameters.AddWithValue("@FineAmount", (object)FineAmount ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PaymentStatus", (object)PaymentStatus ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", (object)CreatedByUserID ?? DBNull.Value);

                        rowsAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                rowsAffected = 0;
            }
            return rowsAffected != 0;
        }

        public static bool DeleteFine(int? FineID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"DELETE Fines
                              WHERE FineID = @FineID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@FineID", (object)FineID ?? DBNull.Value);

                        rowsAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }
            return rowsAffected != 0;
        }

        public static DataTable GetAllFines()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Fines;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                Datatable.Load(reader);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }
            return Datatable;
        }

    }

}