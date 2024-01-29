using Library_Utility;
using Libray_DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Library_DataAccessLayer
{
    public class clsReservationData
    {
        public static bool GetReservationInfoByID(int? ReservationID, ref int? MemberID, ref int? BookCopyID, ref DateTime? ReservationDate)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * 
                            FROM Reservations 
                            WHERE ReservationID = @ReservationID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", (object)ReservationID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                IsFound = true;

                                MemberID = (reader["MemberID"] != DBNull.Value) ? (int?)reader["MemberID"] : null;

                                BookCopyID = (reader["BookCopyID"] != DBNull.Value) ? (int?)reader["BookCopyID"] : null;

                                ReservationDate = (reader["ReservationDate"] != DBNull.Value) ? (DateTime?)reader["ReservationDate"] : null;

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

        public static bool IsReservationExist(int? ReservationID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT IsFound = 1 
                             FROM Reservations
                             WHERE ReservationID = @ReservationID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReservationID", (object)ReservationID ?? DBNull.Value);

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

        public static int? AddNewReservation(int? MemberID, int? BookCopyID, DateTime? ReservationDate)
        {
            int? ReservationID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Reservations (MemberID,BookCopyID,ReservationDate)
                            VALUES (@MemberID,@BookCopyID,@ReservationDate);
                            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BookCopyID", (object)BookCopyID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReservationDate", (object)ReservationDate ?? DBNull.Value);

                        object InsertedRowID = command.ExecuteScalar();

                        //Check if the new ReservationID was successfully inserted
                        if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                        {
                            ReservationID = InsertedID;
                        }

                        // Set ReservationID to null to indicate failure
                        else
                            ReservationID = null;

                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                ReservationID = null;
            }
            return ReservationID;
        }

        public static bool UpdateReservationInfo(int? ReservationID, int? MemberID, int? BookCopyID, DateTime? ReservationDate)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Reservations
                            SET 
							MemberID = @MemberID,
							BookCopyID = @BookCopyID,
							ReservationDate = @ReservationDate
                            WHERE ReservationID = @ReservationID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ReservationID", (object)ReservationID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BookCopyID", (object)BookCopyID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@ReservationDate", (object)ReservationDate ?? DBNull.Value);

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

        public static bool DeleteReservation(int? ReservationID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"DELETE Reservations
                              WHERE ReservationID = @ReservationID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ReservationID", (object)ReservationID ?? DBNull.Value);

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

        public static DataTable GetAllReservations()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT ReservationID AS 'Reservation ID' , FirstName + ' ' + LastName AS 'Full Name' ,
                                    LibraryCardNumber AS 'LibraryCard No', Title AS 'Book Title' , BookCopies.BookCopyID AS 'Copy ID' ,
                                    ReservationDate AS 'Reservation Date'
                                    FROM Reservations
                                    INNER JOIN Members ON Members.MemberID = Reservations.MemberID
                                    INNER JOIN People ON People.PersonID = Members.PersonID 
                                    INNER JOIN BookCopies ON BookCopies.BookCopyID = Reservations.BookCopyID
                                    INNER JOIN Books ON Books.BookID = BookCopies.BookID;";

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

        public static DataTable GetMemberReservations(int? MemberID)
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT ReservationID AS 'Reservation ID' , FirstName + ' ' + LastName AS 'Full Name' ,
                                    LibraryCardNumber AS 'LibraryCard No', Title AS 'Book Title' , BookCopies.BookCopyID AS 'Copy ID' ,
                                    ReservationDate AS 'Reservation Date'
                                    FROM Reservations
                                    INNER JOIN Members ON Members.MemberID = Reservations.MemberID
                                    INNER JOIN People ON People.PersonID = Members.PersonID 
                                    INNER JOIN BookCopies ON BookCopies.BookCopyID = Reservations.BookCopyID
                                    INNER JOIN Books ON Books.BookID = BookCopies.BookID
                                    WHERE Members.MemberID = @MemberID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", (object)MemberID ?? DBNull.Value);

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

        public static DataTable GetBookCopyReservations(int? BookCopyID)
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT ReservationID AS 'Reservation ID' , FirstName + ' ' + LastName AS 'Full Name' ,
                                    LibraryCardNumber AS 'LibraryCard No', Title AS 'Book Title' , BookCopies.BookCopyID AS 'Copy ID' ,
                                    ReservationDate AS 'Reservation Date'
                                    FROM Reservations
                                    INNER JOIN Members ON Members.MemberID = Reservations.MemberID
                                    INNER JOIN People ON People.PersonID = Members.PersonID 
                                    INNER JOIN BookCopies ON BookCopies.BookCopyID = Reservations.BookCopyID
                                    INNER JOIN Books ON Books.BookID = BookCopies.BookID
                                    WHERE BookCopies.BookCopyID = @BookCopyID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookCopyID", (object)BookCopyID ?? DBNull.Value);

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