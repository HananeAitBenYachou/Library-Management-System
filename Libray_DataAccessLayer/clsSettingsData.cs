using Library_Utility;
using Libray_DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Library_DataAccessLayer
{
    public class clsSettingsData
    {
        public static void GetSettingsInfo(ref byte? DefaultBorrowDays, ref float? DefaultFinePerDay)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * 
                            FROM Settings;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DefaultBorrowDays = (reader["DefaultBorrowDays"] != DBNull.Value) ? (byte?)reader["DefaultBorrowDays"] : null;

                                if ((reader["DefaultFinePerDay"] != DBNull.Value))
                                {
                                    DefaultFinePerDay = Convert.ToSingle(reader["DefaultFinePerDay"]);
                                }
                                else
                                {
                                    DefaultFinePerDay = null;
                                }

                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
            }
        }

        public static bool UpdateSettingsInfo(byte? DefaultBorrowDays, float? DefaultFinePerDay)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Settings
                            SET 
							DefaultFinePerDay = @DefaultFinePerDay
                            WHERE DefaultBorrowDays = @DefaultBorrowDays;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@DefaultBorrowDays", (object)DefaultBorrowDays ?? DBNull.Value);
                        command.Parameters.AddWithValue("@DefaultFinePerDay", (object)DefaultFinePerDay ?? DBNull.Value);

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

        public static DataTable GetAllSettings()
        {
            DataTable Datatable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Settings;";

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