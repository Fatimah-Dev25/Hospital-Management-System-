using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data
{
    internal static class PermissionTypeRepository
    {

        public static List<(int ID, string Type, string Description)> GetPermissionTypes()
        {
            var result = new List<(int, string, string)>();
            
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetAllPermissionTypes", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add((reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));

                            }

                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                DatabaseHelper.LogMessage("SQL Error: " + ex.Message, DatabaseHelper.EventType.Error);
            }
            catch (Exception ex)
            {
                DatabaseHelper.LogMessage("General Error: " + ex.Message, DatabaseHelper.EventType.Error);
            }

            return result;
        }
   
        public static List<(int TypeID, string Type, string Description)> GetPermissionTypeDetailsByID(int typeID)
        {
            var permissionTypeDetails = new List<(int, string, string)>();
            
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetPermisionTypeDetailsByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@permissionTypeID", typeID);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                permissionTypeDetails.Add((reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                                DatabaseHelper.LogMessage($"Fetched Permission Type Details with ID {typeID}", DatabaseHelper.EventType.Information);
                            }
                            
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                DatabaseHelper.LogMessage("SQL Error: " + ex.Message, DatabaseHelper.EventType.Error);
            }
            catch (Exception ex)
            {
                DatabaseHelper.LogMessage("General Error: " + ex.Message, DatabaseHelper.EventType.Error);
            }

            return permissionTypeDetails;
        }
   
        public static int GetPermissionTypeIDByName(string permissionTypeName)
        {
            int permissionTypeID = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetPermisionTypeIDByName", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@permissionTypeName", permissionTypeName);
                        conn.Open();
                   
                        permissionTypeID = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                DatabaseHelper.LogMessage("SQL Error: " + ex.Message, DatabaseHelper.EventType.Error);
            }
            catch (Exception ex)
            {
                DatabaseHelper.LogMessage("General Error: " + ex.Message, DatabaseHelper.EventType.Error);
            }

            return permissionTypeID;

        }
    }
}
