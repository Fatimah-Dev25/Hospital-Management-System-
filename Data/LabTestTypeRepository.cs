using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data
{
    internal static class LabTestTypeRepository
    {
        public static DataTable GetTestTypesList()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_GetTestTypesList", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {

                                dt.Load(reader);
                                DatabaseHelper.LogMessage("Fetched all Test Types..", DatabaseHelper.EventType.Information);
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
            return dt;
        }
        public static DataTable GetTestTypeByID(int testTypeID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_GetTestTypeInfoByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@testTypeID", testTypeID);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {

                                dt.Load(reader);
                                DatabaseHelper.LogMessage($"Fetch Test Type with ID: {testTypeID}", DatabaseHelper.EventType.Information);
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


            return dt;
        }
        public static int AddNewTestType(string testType, string description, double price, bool isActive, int userID)
        {
            int testTypeID = -1;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_AddTestType", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@testName", testType);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@isActive", isActive);

                        var outputIdParam = new SqlParameter("@testTypeID", SqlDbType.Int)
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

                            testTypeID = (int)outputIdParam.Value;
                            DatabaseHelper.LogMessage($"Test Type added successfully with ID: {testTypeID}", DatabaseHelper.EventType.Information);

                        }
                        else
                        {
                            DatabaseHelper.LogMessage("Failed to retrieve Test Type ID after insert.", DatabaseHelper.EventType.Warning);

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
                DatabaseHelper.LogMessage("Sql Error: " + ex.Message, DatabaseHelper.EventType.Error);
            }



            return testTypeID;
        }
        public static bool DeleteTestType(int testTypeID, int userID)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("DeleteTestType", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@testTypeID", testTypeID);
                      
                        var result = new SqlParameter("@rowsAffacted", SqlDbType.Int);
                        result.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(result);

                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", userID);
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
        public static bool UpdateTestType(int testTypeID, string testType, string description, double price, bool isActive, int userID)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_UpdateTestType", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@testTypeID", testTypeID);
                        cmd.Parameters.AddWithValue("@testName", testType);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@isActive", isActive);

                        var result = new SqlParameter("@rowsAffacted", SqlDbType.Int);
                        result.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(result);

                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", userID);
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
        public static bool ChangeTestTypeActivation(int testTypeID, bool isActive, int userID)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_ChangeTestTypeActivation", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@testTypeID", testTypeID);
                        cmd.Parameters.AddWithValue("@isActive", isActive);

                        var result = new SqlParameter("@rowsAffacted", SqlDbType.Int);
                        result.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(result);

                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", userID);
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

    }
}
