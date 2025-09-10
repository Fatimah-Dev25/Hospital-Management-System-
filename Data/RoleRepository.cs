using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data
{
    internal static class RoleRepository
    {
        public static List<(int RoleID, string Role)> GetAllUsersRole()
        {
            var userRoles = new List<(int ,string)>();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetAllRoles", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) {

                                userRoles.Add((reader.GetInt32(0), reader.GetString(1)));  
                            }


                            DatabaseHelper.LogMessage("Fetched User Roles List", DatabaseHelper.EventType.Information);
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

            return userRoles;

        }

        public static string GetRoleByID(int roleID) {

            string role = "";

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetRoleByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@roleID", roleID);

                        conn.Open();
                        
                        role = cmd.ExecuteScalar()?.ToString();
                        
                        if(string.IsNullOrEmpty(role))
                            DatabaseHelper.LogMessage($"Fetched User Role with ID {roleID}", DatabaseHelper.EventType.Information);
                        
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

            return role;
        }

        public static bool UpdateRole(int roleID, string role, int updatedBy)
        {

            bool isUpdate = false;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_UpdateRole", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@roleID", roleID);
                        cmd.Parameters.AddWithValue("@roleName", role);

                        var rowsAffacted = new SqlParameter("@rowsAffacted", SqlDbType.Int);
                        rowsAffacted.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(rowsAffacted);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        isUpdate = (int)rowsAffacted.Value > 0;                      
                      
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

            return isUpdate;
        }

    }
}
