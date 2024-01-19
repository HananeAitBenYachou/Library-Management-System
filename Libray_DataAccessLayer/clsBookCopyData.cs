using Library_Utility;
using Libray_DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Library_DataAccessLayer
{
    public class clsBookCopyData
    {
        public static bool GetBookCopyInfoByID(int? BookCopyID, ref int? BookID, ref bool? AvailabilityStatus)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * 
                            FROM BookCopies 
                            WHERE BookCopyID = @BookCopyID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookCopyID", (object)BookCopyID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                IsFound = true;

                                BookID = (reader["BookID"] != DBNull.Value) ? (int?)reader["BookID"] : null;

                                AvailabilityStatus = (reader["AvailabilityStatus"] != DBNull.Value) ? (bool?)reader["AvailabilityStatus"] : null;

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

        public static bool IsBookCopyExist(int? BookCopyID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT IsFound = 1 
                             FROM BookCopies
                             WHERE BookCopyID = @BookCopyID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookCopyID", (object)BookCopyID ?? DBNull.Value);

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

        public static int? AddNewBookCopy(int? BookID, bool? AvailabilityStatus)
        {
            int? BookCopyID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO BookCopies (BookID,AvailabilityStatus)
                            VALUES (@BookID,@AvailabilityStatus);
                            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@BookID", (object)BookID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AvailabilityStatus", (object)AvailabilityStatus ?? DBNull.Value);

                        object InsertedRowID = command.ExecuteScalar();

                        //Check if the new BookCopyID was successfully inserted
                        if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                        {
                            BookCopyID = InsertedID;
                        }

                        // Set BookCopyID to null to indicate failure
                        else
                            BookCopyID = null;

                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                BookCopyID = null;
            }
            return BookCopyID;
        }

        public static bool UpdateBookCopyInfo(int? BookCopyID, int? BookID, bool? AvailabilityStatus)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE BookCopies
                            SET 
							BookID = @BookID,
							AvailabilityStatus = @AvailabilityStatus
                            WHERE BookCopyID = @BookCopyID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@BookCopyID", (object)BookCopyID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BookID", (object)BookID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AvailabilityStatus", (object)AvailabilityStatus ?? DBNull.Value);

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

        public static bool UpdateBookCopyAvailabilityStatus(int? BookCopyID , bool? AvailabilityStatus)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE BookCopies
                            SET 
							AvailabilityStatus = @AvailabilityStatus
                            WHERE BookCopyID = @BookCopyID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookCopyID", (object)BookCopyID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AvailabilityStatus", (object)AvailabilityStatus ?? DBNull.Value);

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

        public static bool DeleteBookCopy(int? BookCopyID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"DELETE BookCopies
                              WHERE BookCopyID = @BookCopyID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookCopyID", (object)BookCopyID ?? DBNull.Value);

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

        public static bool DeleteBookCopies(int? BookID)
        {
            int totalBookCopies = GetNumberOfTableCopies(BookID); 

            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"DELETE BookCopies
                              WHERE BookID = @BookID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", (object)BookID ?? DBNull.Value);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }
            return rowsAffected == totalBookCopies;
        }

        public static DataTable GetAllBookCopies()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM BookCopies;";

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

        public static DataTable GetAllBookCopies(int? BookID)
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM BookCopies WHERE BookID = @BookID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", (object)BookID ?? DBNull.Value);

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

        public static int GetNumberOfTableCopies(int? BookID)
        {
            int CopiesCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT COUNT(BookCopyID)
                                     FROM BookCopies WHERE BookID = @BookID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@BookID", (object)BookID ?? DBNull.Value);

                        object rows = command.ExecuteScalar();

                        if (rows != null && int.TryParse(rows.ToString(), out int count))
                        {
                            CopiesCount = count;
                        }

                        else
                            CopiesCount = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                CopiesCount = 0;
            }
            return CopiesCount;
        }

        public static int? GetAvailableBookCopy(int? BookID)
        {
            int? BookCopyID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT TOP 1 BookCopyID
                                    FROM BookCopies
                                    WHERE BookID = @BookID AND AvailabilityStatus = 1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", (object)BookID ?? DBNull.Value);

                        object copyID = command.ExecuteScalar();

                        if (copyID != null && int.TryParse(copyID.ToString(), out int _copyID))
                        {
                            BookCopyID = _copyID;
                        }

                        else
                            BookCopyID = null;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                BookCopyID = null;
            }
            return BookCopyID;
        }

        public static int? GetBorrowedBookCopy(int? BookID)
        {
            int? BookCopyID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"SELECT TOP 1 BookCopyID
                                    FROM BookCopies
                                    WHERE BookID = @BookID AND AvailabilityStatus = 0";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", (object)BookID ?? DBNull.Value);

                        object copyID = command.ExecuteScalar();

                        if (copyID != null && int.TryParse(copyID.ToString(), out int _copyID))
                        {
                            BookCopyID = _copyID;
                        }

                        else
                            BookCopyID = null;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                BookCopyID = null;
            }
            return BookCopyID;
        }

    }
}