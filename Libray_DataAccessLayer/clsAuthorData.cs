using Library_Utility;
using Libray_DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Library_DataAccessLayer
{
    public class clsAuthorData
    {
        public static bool GetAuthorInfoByID(int? AuthorID, ref int? NationalityCountryID, ref string Biography, ref string FullName)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * 
                            FROM Authors 
                            WHERE AuthorID = @AuthorID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AuthorID", (object)AuthorID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                IsFound = true;

                                NationalityCountryID = (reader["NationalityCountryID"] != DBNull.Value) ? (int?)reader["NationalityCountryID"] : null;

                                Biography = (reader["Biography"] != DBNull.Value) ? (string)reader["Biography"] : null;

                                FullName = (reader["FullName"] != DBNull.Value) ? (string)reader["FullName"] : null;

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

        public static bool GetAuthorInfoByName(string FullName , ref int? AuthorID, ref int? NationalityCountryID, ref string Biography)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * 
                            FROM Authors 
                            WHERE FullName = @FullName;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", (object)FullName ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                IsFound = true;

                                AuthorID = (reader["AuthorID"] != DBNull.Value) ? (int?)reader["AuthorID"] : null;

                                NationalityCountryID = (reader["NationalityCountryID"] != DBNull.Value) ? (int?)reader["NationalityCountryID"] : null;

                                Biography = (reader["Biography"] != DBNull.Value) ? (string)reader["Biography"] : null;

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

        public static bool IsAuthorExist(int? AuthorID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT IsFound = 1 
                             FROM Authors
                             WHERE AuthorID = @AuthorID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AuthorID", (object)AuthorID ?? DBNull.Value);

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

        public static bool IsAuthorExist(string FullName)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT IsFound = 1 
                             FROM Authors
                             WHERE FullName = @FullName;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", (object)FullName ?? DBNull.Value);

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

        public static int? AddNewAuthor(int? NationalityCountryID, string Biography, string FullName)
        {
            int? AuthorID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Authors (NationalityCountryID,Biography,FullName)
                            VALUES (@NationalityCountryID,@Biography,@FullName);
                            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@NationalityCountryID", (object)NationalityCountryID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Biography", (object)Biography ?? DBNull.Value);
                        command.Parameters.AddWithValue("@FullName", (object)FullName ?? DBNull.Value);

                        object InsertedRowID = command.ExecuteScalar();

                        //Check if the new AuthorID was successfully inserted
                        if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                        {
                            AuthorID = InsertedID;
                        }

                        // Set AuthorID to null to indicate failure
                        else
                            AuthorID = null;

                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                AuthorID = null;
            }
            return AuthorID;
        }

        public static bool UpdateAuthorInfo(int? AuthorID, int? NationalityCountryID, string Biography, string FullName)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Authors
                            SET 
							NationalityCountryID = @NationalityCountryID,
							Biography = @Biography,
							FullName = @FullName
                            WHERE AuthorID = @AuthorID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@AuthorID", (object)AuthorID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NationalityCountryID", (object)NationalityCountryID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Biography", (object)Biography ?? DBNull.Value);
                        command.Parameters.AddWithValue("@FullName", (object)FullName ?? DBNull.Value);

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

        public static bool DeleteAuthor(int? AuthorID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"DELETE Authors
                              WHERE AuthorID = @AuthorID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@AuthorID", (object)AuthorID ?? DBNull.Value);

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

        public static DataTable GetAllAuthors()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT AuthorID AS 'Author ID', FullName AS 'Name' , CountryName AS 'Nationality', 
                                    Biography
                                    FROM AUTHORS
                                    INNER JOIN Countries ON Countries.CountryID = Authors.NationalityCountryID;";

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