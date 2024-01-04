using Library_Utility;
using Libray_DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Library_DataAccessLayer
{
    public class clsBorrowingRecordData
    {
        public static bool GetBorrowingRecordInfoByID(int? BorrowingRecordID, ref int? MemberID, ref int? BookCopyID,
            ref DateTime? BorrowingDate, ref DateTime? DueDate, ref DateTime? ActualReturnDate,
            ref int? CreatedByUserID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * 
                            FROM BorrowingRecords 
                            WHERE BorrowingRecordID = @BorrowingRecordID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowingRecordID", (object)BorrowingRecordID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                IsFound = true;

                                MemberID = (reader["MemberID"] != DBNull.Value) ? (int?)reader["MemberID"] : null;

                                BookCopyID = (reader["BookCopyID"] != DBNull.Value) ? (int?)reader["BookCopyID"] : null;

                                BorrowingDate = (reader["BorrowingDate"] != DBNull.Value) ? (DateTime?)reader["BorrowingDate"] : null;

                                DueDate = (reader["DueDate"] != DBNull.Value) ? (DateTime?)reader["DueDate"] : null;

                                ActualReturnDate = (reader["ActualReturnDate"] != DBNull.Value) ? (DateTime?)reader["ActualReturnDate"] : null;

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

        public static bool IsBorrowingRecordExist(int? BorrowingRecordID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT IsFound = 1 
                             FROM BorrowingRecords
                             WHERE BorrowingRecordID = @BorrowingRecordID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowingRecordID", (object)BorrowingRecordID ?? DBNull.Value);

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

        public static int? AddNewBorrowingRecord(int? MemberID, int? BookCopyID, DateTime? BorrowingDate,
            DateTime? DueDate, DateTime? ActualReturnDate, int? CreatedByUserID)
        {
            int? BorrowingRecordID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO BorrowingRecords (MemberID,BookCopyID,BorrowingDate,DueDate,ActualReturnDate,CreatedByUserID)
                            VALUES (@MemberID,@BookCopyID,@BorrowingDate,@DueDate,@ActualReturnDate,@CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BookCopyID", (object)BookCopyID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BorrowingDate", (object)BorrowingDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DueDate", (object)DueDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ActualReturnDate", (object)ActualReturnDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", (object)CreatedByUserID ?? DBNull.Value);

                        object InsertedRowID = command.ExecuteScalar();

                        //Check if the new BorrowingRecordID was successfully inserted
                        if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                        {
                            BorrowingRecordID = InsertedID;
                        }

                        // Set BorrowingRecordID to null to indicate failure
                        else
                            BorrowingRecordID = null;

                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                BorrowingRecordID = null;
            }
            return BorrowingRecordID;
        }

        public static bool UpdateBorrowingRecordInfo(int? BorrowingRecordID, int? MemberID,
            int? BookCopyID, DateTime? BorrowingDate, DateTime? DueDate,
            DateTime? ActualReturnDate, int? CreatedByUserID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE BorrowingRecords
                            SET 
							MemberID = @MemberID,
							BookCopyID = @BookCopyID,
							BorrowingDate = @BorrowingDate,
							DueDate = @DueDate,
							ActualReturnDate = @ActualReturnDate,
							CreatedByUserID = @CreatedByUserID
                            WHERE BorrowingRecordID = @BorrowingRecordID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@BorrowingRecordID", (object)BorrowingRecordID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BookCopyID", (object)BookCopyID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BorrowingDate", (object)BorrowingDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DueDate", (object)DueDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ActualReturnDate", (object)ActualReturnDate ?? DBNull.Value);
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

        public static bool DeleteBorrowingRecord(int? BorrowingRecordID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"DELETE BorrowingRecords
                              WHERE BorrowingRecordID = @BorrowingRecordID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@BorrowingRecordID", (object)BorrowingRecordID ?? DBNull.Value);

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

        public static DataTable GetAllBorrowingRecords()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM BorrowingRecords;";

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