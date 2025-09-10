using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data
{
    internal static class UserRepository
    {

        public static DataTable GetUsersList()
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetUsersList", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                result.Load(reader);

                            DatabaseHelper.LogMessage("Fetched Users List", DatabaseHelper.EventType.Information);
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
        public static DataTable GetUserInfoByID(int userID)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetUserInfoByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@userID", userID);
                        conn.Open();
                 
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                result.Load(reader);

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
        public static bool IsUserExistsByUserID(int userID)
        {

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_IsUserExistsByUserID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserID", userID);

                        var existsParam = new SqlParameter("@Exists", SqlDbType.Bit);
                      
                        existsParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(existsParam);
                        conn.Open();

                        cmd.ExecuteNonQuery();

                        return Convert.ToBoolean(existsParam.Value);
                       
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

            return false;
        }
        public static bool IsUserExistsByPersonID(int personID)
        {

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_IsUserExistsByPersonID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PersonID", personID);

                        var existsParam = new SqlParameter("@Exists", SqlDbType.Bit);

                        existsParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(existsParam);
                        conn.Open();

                        cmd.ExecuteNonQuery();

                        return Convert.ToBoolean(existsParam.Value);

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

            return false;
        }
        public static bool IsUserExistsByCredentials(string username, string passwordHash)
        {

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_IsUserExistsByCredentials", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                        var existsParam = new SqlParameter("@Exists", SqlDbType.Bit);

                        existsParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(existsParam);
                        conn.Open();

                        cmd.ExecuteNonQuery();

                        return Convert.ToBoolean(existsParam.Value);

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

            return false;
        }
        public static DataRow GetUserByCredentials(string username, string passwordHash)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetUserByCredentials", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                result.Load(reader);

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

            return result.Rows.Count > 0 ? result.Rows[0] : null;
        }
        public static int AddUser(int personId, string username, string passwordHash, int roleId,  bool isActive, int createdBy)
        {
            int userID = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_AddNewUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@personID", personId);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@hashPassword", passwordHash);
                        cmd.Parameters.AddWithValue("@roleID", roleId);
                        cmd.Parameters.AddWithValue("@isActive", isActive);
                        
                        var outputIdParam = new SqlParameter("@UserAddedID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputIdParam);

                        conn.Open();
                       
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", createdBy);
                            contextCmd.ExecuteNonQuery();
                        }
                        cmd.ExecuteNonQuery();

                        if (outputIdParam.Value != DBNull.Value)
                        {
                            userID = (int)outputIdParam.Value;
                            DatabaseHelper.LogMessage($"User added successfully with ID {userID}", DatabaseHelper.EventType.Information);
                        }
                        else
                        {
                            DatabaseHelper.LogMessage("Failed to retrive User ID after insert", DatabaseHelper.EventType.Warning);
                        }
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

            return userID;
        }
        public static bool ChangeUserActivation(int userID, bool isActive ,int updatedBy)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_ChangeUserActivation", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@isActive", isActive);
                        
                        var result = new SqlParameter("@rowsAffacted", SqlDbType.Int);
                        result.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(result);

                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", updatedBy);
                            contextCmd.ExecuteNonQuery();
                        }
                        cmd.ExecuteNonQuery();

                        rowsAffacted = (int)result.Value;

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

            return rowsAffacted > 0;
        }
        public static bool UpdateUserInfoByID(int userId, int roleId, string username, bool isActive, int updatedBy)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_UpdateUserInfoByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@RoleID", roleId);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@IsActive", isActive);


                        var result = new SqlParameter("@rowsAffacted", SqlDbType.Int);
                        result.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(result);


                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", updatedBy);
                            contextCmd.ExecuteNonQuery();
                        }
                        cmd.ExecuteNonQuery();

                        rowsAffacted = (int)result.Value;

                        DatabaseHelper.LogMessage($"User updated successfully. ID: {userId}", DatabaseHelper.EventType.Information);
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

            return rowsAffacted > 0;
        }
        public static bool ChangePassword(int userId, string newPasswordHash, int updatedBy)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_ChangePassword", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@NewPasswordHash", newPasswordHash);
         

                        var result = new SqlParameter("@rowsAffacted", SqlDbType.Int);
                        result.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(result);


                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", updatedBy);
                            contextCmd.ExecuteNonQuery();
                        }
                        cmd.ExecuteNonQuery();

                        rowsAffacted = (int)result.Value;
                        
                        if(rowsAffacted > 0) 
                            DatabaseHelper.LogMessage($"Password Changed successfully.", DatabaseHelper.EventType.Information);
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

            return rowsAffacted > 0;
        }
        public static bool CheckUsernameExists(string username)
        {

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_CheckUsernameExists", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", username);

                        conn.Open();

                        
                        return Convert.ToInt32(cmd.ExecuteScalar()) == 1;

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

            return false;
        }

    }
}
