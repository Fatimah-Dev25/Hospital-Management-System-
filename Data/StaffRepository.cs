using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data
{
    internal static class StaffRepository
    {
        public static int AddStaff(string job, int shiftType, DateTime dateHired, int personID, int deptID, bool isActive, int userID)
        {
            int staffID = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("AddStaff", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@jobTitle", job);
                        cmd.Parameters.AddWithValue("@shiftType", shiftType);
                        cmd.Parameters.AddWithValue("@dateHired", dateHired);
                        cmd.Parameters.AddWithValue("@personID", personID);
                        cmd.Parameters.AddWithValue("@deptID", deptID);
                        cmd.Parameters.AddWithValue("@isActive", isActive);
         
                        
                        var outputIdParam = new SqlParameter("@staffID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        cmd.Parameters.Add(outputIdParam);

                        conn.Open();
                       
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", userID);
                            contextCmd.ExecuteNonQuery();
                        }

                        cmd.ExecuteNonQuery();

                        if (outputIdParam.Value != DBNull.Value)
                        {

                            staffID = (int)outputIdParam.Value;
                            DatabaseHelper.LogMessage($"Staff added successfully with ID: {staffID}", DatabaseHelper.EventType.Information);

                        }
                        else
                        {
                            DatabaseHelper.LogMessage("Failed to retrieve StaffID after insert.", DatabaseHelper.EventType.Warning);

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

            return staffID;
        }
        public static bool DeleteStaff(int staffID, int userID)
        {
            bool isDelete = false;

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("DeleteStaff", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@staffID", staffID);

                        var rowsAffacted = new SqlParameter("@rowsAffacted", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        cmd.Parameters.Add(rowsAffacted);
                        
                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", userID);
                            contextCmd.ExecuteNonQuery();
                        }
                        cmd.ExecuteNonQuery();
                                               
                        isDelete = (int)rowsAffacted.Value > 0;

                        DatabaseHelper.LogMessage($"Staff deleted successfully. ID: {staffID}", DatabaseHelper.EventType.Information);
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

            return isDelete;
        }
        public static DataTable GetStaffList()
        {

            DataTable result = new DataTable();

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("GetStaffList", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                                result.Load(reader);

                            DatabaseHelper.LogMessage("Fetched all Staff", DatabaseHelper.EventType.Information);


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

            return result;
        }
        public static DataTable GetStaffInfoByID(int staffID)
        {

            DataTable result = new DataTable();
            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("GetStaffInfoByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@staffID", staffID);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                result.Load(reader);
                                DatabaseHelper.LogMessage($"Fetched Staff by ID {staffID}", DatabaseHelper.EventType.Information);

                            }

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
            return result;
        }
        public static bool UpdateStaffInfo(int staffID, string jobTitle, int shiftType, DateTime dateHired, int personID, int deptID, bool isActive, int userID)
        {

            bool isUpdated = false;

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("UpdateStaffInfo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@staffID", staffID);
                        cmd.Parameters.AddWithValue("@jobTitle", jobTitle);
                        cmd.Parameters.AddWithValue("@shiftType", shiftType);
                        cmd.Parameters.AddWithValue("@dateHired", dateHired);
                        cmd.Parameters.AddWithValue("@personID", personID);
                        cmd.Parameters.AddWithValue("@deptID", deptID);
                        cmd.Parameters.AddWithValue("@isActive", isActive);

                        var rowsAffacted = new SqlParameter("@rowsAffacted", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        cmd.Parameters.Add(rowsAffacted);
                        
                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", userID);
                            contextCmd.ExecuteNonQuery();
                        }
                        cmd.ExecuteNonQuery();

                        isUpdated = (int)rowsAffacted.Value > 0; 
                            

                        DatabaseHelper.LogMessage($"Staff Info updated successfully. ID: {staffID}", DatabaseHelper.EventType.Information);
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

            return isUpdated;
        }
        public static bool DeactivateEmployee(int staffID, int userID)
        {

            bool isUpdated = false;

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("DeactivateEmployee", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@staffID", staffID);
                      
                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", userID);
                            contextCmd.ExecuteNonQuery();
                        }
                        isUpdated = cmd.ExecuteNonQuery() > 0;

                        DatabaseHelper.LogMessage($"Employee deactivated successfully. ID: {staffID}", DatabaseHelper.EventType.Information);
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

            return isUpdated;
        }

        public static bool IsEmployeeExistsForPerson(int personID)
        {
            bool exists = false;

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("IsEmployeeExistsForPerson", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@personID", personID);

                        conn.Open();
                        object result = cmd.ExecuteScalar();

                        exists = result != null && Convert.ToInt32(result) == 1;
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

            return exists;
        }

    }
}
