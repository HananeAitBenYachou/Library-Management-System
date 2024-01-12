using Library_Utility;
using Libray_DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Library_DataAccessLayer
{
    public class clsGenreData
    {
        public static bool GetGenreInfoByID(int? GenreID, ref string GenreName, ref string Description)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * 
                            FROM Genres 
                            WHERE GenreID = @GenreID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GenreID", (object)GenreID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                IsFound = true;

                                GenreName = (reader["GenreName"] != DBNull.Value) ? (string)reader["GenreName"] : null;

                                Description = (reader["Description"] != DBNull.Value) ? (string)reader["Description"] : null;

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

        public static bool GetGenreInfoByName(string GenreName, ref int? GenreID, ref string Description)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * 
                            FROM Genres 
                            WHERE GenreName = @GenreName;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GenreName", (object)GenreName ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                IsFound = true;

                                GenreID = (reader["GenreID"] != DBNull.Value) ? (int?)reader["GenreID"] : null;

                                Description = (reader["Description"] != DBNull.Value) ? (string)reader["Description"] : null;
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

        public static bool IsGenreExist(int? GenreID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT IsFound = 1 
                             FROM Genres
                             WHERE GenreID = @GenreID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GenreID", (object)GenreID ?? DBNull.Value);

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

        public static bool IsGenreExist(string GenreName)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT IsFound = 1 
                             FROM Genres
                             WHERE GenreName = @GenreName;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GenreName", (object)GenreName ?? DBNull.Value);

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

        public static int? AddNewGenre(string GenreName, string Description)
        {
            int? GenreID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Genres (GenreName,Description)
                            VALUES (@GenreName,@Description);
                            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@GenreName", (object)GenreName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);

                        object InsertedRowID = command.ExecuteScalar();

                        //Check if the new GenreID was successfully inserted
                        if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                        {
                            GenreID = InsertedID;
                        }

                        // Set GenreID to null to indicate failure
                        else
                            GenreID = null;

                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                GenreID = null;
            }
            return GenreID;
        }

        public static bool UpdateGenreInfo(int? GenreID, string GenreName, string Description)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Genres
                            SET 
							GenreName = @GenreName,
							Description = @Description
                            WHERE GenreID = @GenreID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@GenreID", (object)GenreID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GenreName", (object)GenreName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Description", (object)Description ?? DBNull.Value);

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

        public static bool DeleteGenre(int? GenreID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"DELETE Genres
                              WHERE GenreID = @GenreID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@GenreID", (object)GenreID ?? DBNull.Value);

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

        public static DataTable GetAllGenres()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT GenreID AS 'Genre ID' , GenreName 
                                    AS 'Genre Name' , Description
                                    FROM Genres;";

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