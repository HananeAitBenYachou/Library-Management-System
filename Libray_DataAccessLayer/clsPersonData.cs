using Library_Utility;
using Libray_DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Library_DataAccessLayer
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(int? PersonID, ref string FirstName, ref string LastName, ref string NationalNo, 
            ref char? Gender, ref DateTime? BirthDate, ref string Address, ref string Phone, 
            ref string Email, ref int? NationalityCountryID, ref string PersonalImagePath, ref string Password)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * 
                            FROM People 
                            WHERE PersonID = @PersonID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                IsFound = true;

                                FirstName = (reader["FirstName"] != DBNull.Value) ? (string)reader["FirstName"] : null;

                                LastName = (reader["LastName"] != DBNull.Value) ? (string)reader["LastName"] : null;

                                NationalNo = (reader["NationalNo"] != DBNull.Value) ? (string)reader["NationalNo"] : null;

                                if ((reader["Gender"] != DBNull.Value))                             
                                    Gender = char.Parse((string)reader["Gender"]);
                                
                                else                               
                                    Gender = null;
                                
                                BirthDate = (reader["BirthDate"] != DBNull.Value) ? (DateTime?)reader["BirthDate"] : null;

                                Address = (reader["Address"] != DBNull.Value) ? (string)reader["Address"] : null;

                                Phone = (reader["Phone"] != DBNull.Value) ? (string)reader["Phone"] : null;

                                Email = (reader["Email"] != DBNull.Value) ? (string)reader["Email"] : null;

                                NationalityCountryID = (reader["NationalityCountryID"] != DBNull.Value) ? (int?)reader["NationalityCountryID"] : null;

                                PersonalImagePath = (reader["PersonalImagePath"] != DBNull.Value) ? (string)reader["PersonalImagePath"] : null;

                                Password = (reader["Password"] != DBNull.Value) ? (string)reader["Password"] : null;

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

        public static bool GetPersonInfoByNationalNo(string NationalNo , ref int? PersonID, ref string FirstName, ref string LastName,
            ref char? Gender, ref DateTime? BirthDate, ref string Address, ref string Phone,
            ref string Email, ref int? NationalityCountryID, ref string PersonalImagePath, ref string Password)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * 
                            FROM People 
                            WHERE NationalNo = @NationalNo;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", (object)NationalNo ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found successfully !
                                IsFound = true;

                                PersonID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;

                                FirstName = (reader["FirstName"] != DBNull.Value) ? (string)reader["FirstName"] : null;

                                LastName = (reader["LastName"] != DBNull.Value) ? (string)reader["LastName"] : null;

                                if ((reader["Gender"] != DBNull.Value))
                                    Gender = char.Parse((string)reader["Gender"]);

                                else
                                    Gender = null;

                                BirthDate = (reader["BirthDate"] != DBNull.Value) ? (DateTime?)reader["BirthDate"] : null;

                                Address = (reader["Address"] != DBNull.Value) ? (string)reader["Address"] : null;

                                Phone = (reader["Phone"] != DBNull.Value) ? (string)reader["Phone"] : null;

                                Email = (reader["Email"] != DBNull.Value) ? (string)reader["Email"] : null;

                                NationalityCountryID = (reader["NationalityCountryID"] != DBNull.Value) ? (int?)reader["NationalityCountryID"] : null;

                                PersonalImagePath = (reader["PersonalImagePath"] != DBNull.Value) ? (string)reader["PersonalImagePath"] : null;

                                Password = (reader["Password"] != DBNull.Value) ? (string)reader["Password"] : null;

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

        public static bool GetPersonByEmailAndPassword(string Email , string Password, 
                ref string NationalNo, ref int? PersonID, ref string FirstName, ref string LastName,
                ref char? Gender, ref DateTime? BirthDate, ref string Address, ref string Phone,
                ref int? NationalityCountryID, ref string PersonalImagePath)
                    {
                        bool IsFound = false;

                        try
                        {
                            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                            {
                                connection.Open();
                                string query = @"SELECT * 
                                        FROM People 
                                        WHERE Email = @Email AND Password = @Password;";

                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@Password", (object)Password ?? DBNull.Value);
                                    command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);

                                    using (SqlDataReader reader = command.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            // The record was found successfully !
                                            IsFound = true;

                                            PersonID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;

                                            FirstName = (reader["FirstName"] != DBNull.Value) ? (string)reader["FirstName"] : null;

                                            LastName = (reader["LastName"] != DBNull.Value) ? (string)reader["LastName"] : null;

                                            if ((reader["Gender"] != DBNull.Value))
                                                Gender = char.Parse((string)reader["Gender"]);

                                            else
                                                Gender = null;

                                            BirthDate = (reader["BirthDate"] != DBNull.Value) ? (DateTime?)reader["BirthDate"] : null;

                                            Address = (reader["Address"] != DBNull.Value) ? (string)reader["Address"] : null;

                                            Phone = (reader["Phone"] != DBNull.Value) ? (string)reader["Phone"] : null;

                                            NationalNo = (reader["NationalNo"] != DBNull.Value) ? (string)reader["NationalNo"] : null;

                                            NationalityCountryID = (reader["NationalityCountryID"] != DBNull.Value) ? (int?)reader["NationalityCountryID"] : null;

                                            PersonalImagePath = (reader["PersonalImagePath"] != DBNull.Value) ? (string)reader["PersonalImagePath"] : null;
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

        public static bool IsPersonExist(int? PersonID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT IsFound = 1 
                             FROM People
                             WHERE PersonID = @PersonID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

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

        public static bool IsPersonExistByNationalNo(string NationalNo)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT IsFound = 1 
                             FROM People
                             WHERE NationalNo = @NationalNo;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", (object)NationalNo ?? DBNull.Value);

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

        public static bool IsPersonExistByEmail(string Email)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT IsFound = 1 
                             FROM People
                             WHERE Email = @Email;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);

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

        public static int? GetPersonType(int? PersonID)
        {
            int? PersonType = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT 
	                                CASE 
		                                WHEN EXISTS (SELECT 1 FROM Users WHERE PersonID = @PersonID) THEN '1'
		                                WHEN EXISTS (SELECT 1 FROM Members WHERE PersonID = @PersonID ) THEN '2'
		                                ELSE '3'
	                                END AS 'Person Type';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

                        object reader = command.ExecuteScalar();

                        if (reader != null && int.TryParse(reader.ToString(), out int InsertedID))
                        {
                            PersonType = InsertedID;
                        }

                        else
                            PersonType = null;
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                PersonType = null;
            }
            return PersonType;
        }

        public static int? AddNewPerson(string FirstName, string LastName, string NationalNo,
            char? Gender, DateTime? BirthDate, string Address, string Phone, string Email,
            int? NationalityCountryID, string PersonalImagePath, string Password)
        {
            int? PersonID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO People (FirstName,LastName,NationalNo,Gender,BirthDate,Address,Phone,Email,NationalityCountryID,PersonalImagePath,Password)
                            VALUES (@FirstName,@LastName,@NationalNo,@Gender,@BirthDate,@Address,@Phone,@Email,@NationalityCountryID,@PersonalImagePath,@Password);
                            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@FirstName", (object)FirstName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", (object)LastName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NationalNo", (object)NationalNo ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Gender", (object)Gender ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BirthDate", (object)BirthDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Phone", (object)Phone ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NationalityCountryID", (object)NationalityCountryID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PersonalImagePath", (object)PersonalImagePath ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Password", (object)Password ?? DBNull.Value);

                        object InsertedRowID = command.ExecuteScalar();

                        //Check if the new PersonID was successfully inserted
                        if (InsertedRowID != null && int.TryParse(InsertedRowID.ToString(), out int InsertedID))
                        {
                            PersonID = InsertedID;
                        }

                        // Set PersonID to null to indicate failure
                        else
                            PersonID = null;

                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                PersonID = null;
            }
            return PersonID;
        }

        public static bool UpdatePersonInfo(int? PersonID, string FirstName, string LastName, 
            string NationalNo, char? Gender, DateTime? BirthDate, string Address, 
            string Phone, string Email, int? NationalityCountryID, string PersonalImagePath, string Password)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE People
                            SET 
							FirstName = @FirstName,
							LastName = @LastName,
							NationalNo = @NationalNo,
							Gender = @Gender,
							BirthDate = @BirthDate,
							Address = @Address,
							Phone = @Phone,
							Email = @Email,
							NationalityCountryID = @NationalityCountryID,
							PersonalImagePath = @PersonalImagePath,
							Password = @Password
                            WHERE PersonID = @PersonID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@FirstName", (object)FirstName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@LastName", (object)LastName ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NationalNo", (object)NationalNo ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Gender", (object)Gender ?? DBNull.Value);
                        command.Parameters.AddWithValue("@BirthDate", (object)BirthDate ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Phone", (object)Phone ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@NationalityCountryID", (object)NationalityCountryID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@PersonalImagePath", (object)PersonalImagePath ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Password", (object)Password ?? DBNull.Value);

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

        public static bool DeletePerson(int? PersonID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"DELETE People
                              WHERE PersonID = @PersonID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

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

        public static DataTable GetAllPeople()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM People;";

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

        public static bool UpdatePassword(int? PersonID , string NewPassword)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE People
                            SET 
							Password = @Password
                            WHERE PersonID = @PersonID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Password", (object)NewPassword ?? DBNull.Value);

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

    }
}