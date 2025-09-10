using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data
{
    internal static class BloodTypeRepository
    {
        public static List<(int ID, string Type)> GetAllBloodTypes()
        {
            var result = new List<(int, string)>();

            try
            {
                using (var conn = DatabaseHelper.GetConnection()) {

                    using (var cmd = new SqlCommand("GetAllBloodTypes", conn)) {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (var reader = cmd.ExecuteReader()) {

                            while (reader.Read())
                            {
                                int ID = Convert.ToInt32(reader[0]);
                                string Name = reader.GetString(1);
                                result.Add((ID, Name));
                            }
                            
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                DatabaseHelper.LogMessage("Sql Error: " + ex.Message, DatabaseHelper.EventType.Error);
            }
            catch (Exception ex) {
                DatabaseHelper.LogMessage("General Error: " + ex.Message, DatabaseHelper.EventType.Error);
            }

            return result;
        }
        public static string GetBloodTypeByID(int bloodTypeId) {

            string bloodType = "";
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("GetBloodTypeByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@bloodTypeID", bloodTypeId);

                        conn.Open();
                        
                        bloodType = cmd.ExecuteScalar()?.ToString();

                    }
                }
            }
            catch (SqlException ex)
            {
                DatabaseHelper.LogMessage("Sql Error: " + ex.Message, DatabaseHelper.EventType.Error);
            }
            catch (Exception ex)
            {
                DatabaseHelper.LogMessage("General Error: " + ex.Message, DatabaseHelper.EventType.Error);
            }

            return bloodType;
        }
    
    }
}
