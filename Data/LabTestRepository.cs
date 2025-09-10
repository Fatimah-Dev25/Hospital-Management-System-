using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Data
{
    internal static class LabTestRepository
    {

        public static DataTable GetLabTestsList()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_GetLabTestsList", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {

                                dt.Load(reader);
                                DatabaseHelper.LogMessage("Fetched all Lab Tests ..", DatabaseHelper.EventType.Information);
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

        public static DataTable GetLabTestsListFilterd(int? recordID = null, int? patientId = null)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_GetLabTestsListFilterd", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@medicalRecordID", (object)recordID ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@patientID", (object)patientId ?? DBNull.Value);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dt.Load(reader);
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

        public static DataTable GetLabTestInfoByID(int labTestID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_GetLabTestInfoByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@labTestID", labTestID);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {

                                dt.Load(reader);
                                DatabaseHelper.LogMessage($"Fetch Lab Test Info with ID: {labTestID}", DatabaseHelper.EventType.Information);
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
        public static int AddNewLabTest(int recordID, int testTypeID, DateTime testDate, string result, string notes, int createdby)
        {
            int labTestID = -1;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_AddLabTest", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@recordID", recordID);
                        cmd.Parameters.AddWithValue("@testTypeID", testTypeID);
                        cmd.Parameters.AddWithValue("@testDate", testDate);

                        if (string.IsNullOrEmpty(result))
                            cmd.Parameters.AddWithValue("@result",DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@result", result);
                        

                        if (string.IsNullOrEmpty(notes))
                            cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@notes", notes);

                        cmd.Parameters.AddWithValue("@createdBy", createdby);
                

                        var outputIdParam = new SqlParameter("@labTestID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        cmd.Parameters.Add(outputIdParam);

                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", createdby);
                            contextCmd.ExecuteNonQuery();
                        }
                        cmd.ExecuteNonQuery();

                        if (outputIdParam.Value != DBNull.Value)
                        {

                            labTestID = (int)outputIdParam.Value;
                            DatabaseHelper.LogMessage($"Lab Test added successfully with ID: {testTypeID}", DatabaseHelper.EventType.Information);

                        }
                        else
                        {
                            DatabaseHelper.LogMessage("Failed to retrieve Lab Test ID after insert.", DatabaseHelper.EventType.Warning);

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



            return labTestID;
        }
        public static bool DeleteLabTest(int labTestID, int userID)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_DeleteLabTest", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@labTestID", labTestID);

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
        public static bool UpdateLabTest(DateTime testDate, string result, int labTestID, int userID, string notes = null)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_UpdateLabTest", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@testDate", testDate);

                        if(string.IsNullOrEmpty(result)) 
                            cmd.Parameters.AddWithValue("@result", result);
                        else
                            cmd.Parameters.AddWithValue("@result", DBNull.Value);

                        if(string.IsNullOrEmpty(notes)) 
                            cmd.Parameters.AddWithValue("@notes", notes);
                        else
                            cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                        
                        cmd.Parameters.AddWithValue("@labTestID", labTestID);
                       
                        var outputParameter = new SqlParameter("@rowsAffacted", SqlDbType.Int);
                        outputParameter.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputParameter);

                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", userID);
                            contextCmd.ExecuteNonQuery();
                        }
                        cmd.ExecuteNonQuery();

                        rowsAffacted = (int)outputParameter.Value;
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
        public static bool UpdateLabTestResult(int labTestID, string result, int userID)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_UpdateLabTestResult", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@labTestID", labTestID);
                        cmd.Parameters.AddWithValue("@result", result);
                        

                        var outputParameter = new SqlParameter("@rowsAffacted", SqlDbType.Int);
                        outputParameter.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputParameter);

                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", userID);
                            contextCmd.ExecuteNonQuery();
                        }
                        cmd.ExecuteNonQuery();

                        if (outputParameter.Value != DBNull.Value) {

                            rowsAffacted = (int)outputParameter.Value;
                            DatabaseHelper.LogMessage($"The result for Lab Test ID {labTestID} has been added successfully.", DatabaseHelper.EventType.Information);
                        }
                        else
                        {
                            DatabaseHelper.LogMessage($"Failed to add result for Lab Tes ID {labTestID}", DatabaseHelper.EventType.Warning);
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


            return rowsAffacted > 0;

        }


    }
}
