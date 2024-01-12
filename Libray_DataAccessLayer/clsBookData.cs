using Library_Utility;
using Libray_DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Library_DataAccessLayer
{
    public class clsBookData
    {
        public static bool GetBookInfoByID(int? BookID, ref string Title,
            ref string ISBN, ref int? GenreID, ref string AdditionalDetails, ref int? AuthorID, 
            ref int? CreatedByUserID, ref DateTime? PublicationDate, ref string BookImagePath)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * 
                            FROM Books 
                            WHERE BookID = @BookID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", (object)BookID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                IsFound = true;

                                Title = (reader["Title"] != DBNull.Value) ? (string)reader["Title"] : null;

                                ISBN = (reader["ISBN"] != DBNull.Value) ? (string)reader["ISBN"] : null;

                                GenreID = (reader["GenreID"] != DBNull.Value) ? (int?)reader["GenreID"] : null;

                                AdditionalDetails = (reader["AdditionalDetails"] != DBNull.Value) ? (string)reader["AdditionalDetails"] : null;

                                AuthorID = (reader["AuthorID"] != DBNull.Value) ? (int?)reader["AuthorID"] : null;

                                CreatedByUserID = (reader["CreatedByUserID"] != DBNull.Value) ? (int?)reader["CreatedByUserID"] : null;

                                PublicationDate = (reader["PublicationDate"] != DBNull.Value) ? (DateTime?)reader["PublicationDate"] : null;

                                BookImagePath = (reader["BookImagePath"] != DBNull.Value) ? (string)reader["BookImagePath"] : null;

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

        public static bool GetBookInfoByISBN(string ISBN, ref int? BookID, ref string Title,
      ref int? GenreID, ref string AdditionalDetails, ref int? AuthorID,
      ref int? CreatedByUserID, ref DateTime? PublicationDate, ref string BookImagePath)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * 
                            FROM Books 
                            WHERE ISBN = @ISBN;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ISBN", (object)ISBN ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                IsFound = true;

                                BookID = (reader["BookID"] != DBNull.Value) ? (int?)reader["BookID"] : null;

                                Title = (reader["Title"] != DBNull.Value) ? (string)reader["Title"] : null;

                                GenreID = (reader["GenreID"] != DBNull.Value) ? (int?)reader["GenreID"] : null;

                                AdditionalDetails = (reader["AdditionalDetails"] != DBNull.Value) ? (string)reader["AdditionalDetails"] : null;

                                AuthorID = (reader["AuthorID"] != DBNull.Value) ? (int?)reader["AuthorID"] : null;

                                CreatedByUserID = (reader["CreatedByUserID"] != DBNull.Value) ? (int?)reader["CreatedByUserID"] : null;

                                PublicationDate = (reader["PublicationDate"] != DBNull.Value) ? (DateTime?)reader["PublicationDate"] : null;

                                BookImagePath = (reader["BookImagePath"] != DBNull.Value) ? (string)reader["BookImagePath"] : null;

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

        public static bool IsBookExist(int? BookID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT IsFound = 1 
                             FROM Books
                             WHERE BookID = @BookID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookID", (object)BookID ?? DBNull.Value);

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

        public static bool IsBookExistByTitle(string Title)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT IsFound = 1 
                             FROM Books
                             WHERE Title = @Title;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", (object)Title ?? DBNull.Value);

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

        public static bool IsBookExistByISBN(string ISBN)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT IsFound = 1 
                             FROM Books
                             WHERE ISBN = @ISBN;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ISBN", (object)ISBN ?? DBNull.Value);

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

        public static int? AddNewBook(string Title, string ISBN, int? GenreID, 
            string AdditionalDetails, int? AuthorID, int? CreatedByUserID, 
            DateTime? PublicationDate, string BookImagePath)
        {
            int? BookID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Books (Title,ISBN,GenreID,AdditionalDetails,AuthorID,CreatedByUserID,PublicationDate,BookImagePath)
                            VALUES (@Title,@ISBN,@GenreID,@AdditionalDetails,@AuthorID,@CreatedByUserID,@PublicationDate,@BookImagePath);
                            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Title", (object)Title ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ISBN", (object)ISBN ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GenreID", (object)GenreID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AdditionalDetails", (object)AdditionalDetails ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AuthorID", (object)AuthorID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", (object)CreatedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PublicationDate", (object)PublicationDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BookImagePath", (object)BookImagePath ?? DBNull.Value);

                        object InsertedRowID = command.ExecuteScalar();

                        //Check if the new BookID was successfully inserted
                        if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                        {
                            BookID = InsertedID;
                        }

                        // Set BookID to null to indicate failure
                        else
                            BookID = null;

                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                BookID = null;
            }
            return BookID;
        }

        public static bool UpdateBookInfo(int? BookID, string Title, 
            string ISBN, int? GenreID, string AdditionalDetails, 
            int? AuthorID, int? CreatedByUserID, 
            DateTime? PublicationDate, string BookImagePath)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Books
                            SET 
							Title = @Title,
							ISBN = @ISBN,
							GenreID = @GenreID,
							AdditionalDetails = @AdditionalDetails,
							AuthorID = @AuthorID,
							CreatedByUserID = @CreatedByUserID,
							PublicationDate = @PublicationDate,
							BookImagePath = @BookImagePath
                            WHERE BookID = @BookID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@BookID", (object)BookID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Title", (object)Title ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ISBN", (object)ISBN ?? DBNull.Value);
                        command.Parameters.AddWithValue("@GenreID", (object)GenreID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AdditionalDetails", (object)AdditionalDetails ?? DBNull.Value);
                        command.Parameters.AddWithValue("@AuthorID", (object)AuthorID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", (object)CreatedByUserID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PublicationDate", (object)PublicationDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BookImagePath", (object)BookImagePath ?? DBNull.Value);

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

        public static bool DeleteBook(int? BookID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"DELETE Books
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
            return rowsAffected != 0;
        }

        public static DataTable GetAllBooks()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT BookID AS 'Book ID', Title , ISBN , Authors.FullName AS 'Author', 
                                    Genres.GenreName AS 'Genre', (SELECT COUNT(BookCopyID) FROM BookCopies WHERE BookCopies.BookID = Books.BookID) AS 'Quantity',
                                    PublicationDate AS 'Publication Date', AdditionalDetails AS 'Additional Details'
                                    FROM Books
                                    INNER JOIN Authors ON Books.AuthorID = Authors.AuthorID
                                    INNER JOIN Genres ON Books.GenreID = Genres.GenreID;";

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
