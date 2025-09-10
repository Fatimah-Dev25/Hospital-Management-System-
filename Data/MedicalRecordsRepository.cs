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
    internal static class MedicalRecordsRepository
    {

        public static DataTable GetMedicalRecordsList()
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetMedicalRecordsList", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                result.Load(reader);

                            DatabaseHelper.LogMessage("Fetched Medical Records List", DatabaseHelper.EventType.Information);
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
        public static DataTable GetPatientRecords(int patientID)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetPatientRecords", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@patientID", patientID);

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
        public static DataTable GetRecordByID(int recordID)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetRecordDetailsByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@recordID", recordID);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                result.Load(reader);

                            DatabaseHelper.LogMessage($"Fetched Record with ID {recordID} details.", DatabaseHelper.EventType.Information);
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
        public static int AddPatientRecord(int patientID, int doctorID, string diagnosis, string treatment,
             int createdBy, int appointmentID ,string notes = null)
        {
            int recordID = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_AddPatientRecord", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@patientID", patientID);
                        cmd.Parameters.AddWithValue("@appointmentID", appointmentID);
                        cmd.Parameters.AddWithValue("@doctorID", doctorID);
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);
                        cmd.Parameters.AddWithValue("@treatment", treatment);
                        
                        if(!string.IsNullOrEmpty(notes))
                            cmd.Parameters.AddWithValue("@notes", notes);
                        else
                            cmd.Parameters.AddWithValue("@notes", DBNull.Value);

                   
                        cmd.Parameters.AddWithValue("@createdBy", createdBy);
                        
                      
                        var outputIdParam = new SqlParameter("@medicalRecordID", SqlDbType.Int)
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
                            recordID = (int)outputIdParam.Value;
                            DatabaseHelper.LogMessage($"Record added successfully with ID: {recordID}", DatabaseHelper.EventType.Information);
                        }
                        else
                        {
                            DatabaseHelper.LogMessage("Failed to retrieve RecordID after insert.", DatabaseHelper.EventType.Warning);
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

            return recordID;
        }
        public static bool DeleteRecord(int recordID, int userID)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_DeleteRecord", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@recordID", recordID);
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

                        DatabaseHelper.LogMessage($"Record deleted successfully. ID: {recordID}", DatabaseHelper.EventType.Warning);
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
        public static bool UpdateRecord(int recordID, string diagnosis, string treatment, int userID,string notes = null)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_UpdateRecordInfo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@recordID", recordID);
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);
                        cmd.Parameters.AddWithValue("@treatment", treatment);
                        
                        if(!string.IsNullOrEmpty(notes)) 
                            cmd.Parameters.AddWithValue("@notes", notes);
                        else
                            cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                
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

                        DatabaseHelper.LogMessage($"Record updated successfully. ID: {recordID}", DatabaseHelper.EventType.Information);
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

        public static bool CheckRecordExists(int recordID)
        {
            bool recordExists = false;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("sp_CheckRecordExits", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@RecordID", recordID);

                        conn.Open();
                        var result = cmd.ExecuteScalar();

                        if (result != null) { 
                        
                            recordExists = Convert.ToInt32(result) == 1;
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

            return recordExists;
        }

        public static bool HasActiveAppointment(int recordID)
        {
            bool activeAppointment = false;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_HasRecordActiveAppointment", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@recordID", recordID);

                        var result = new SqlParameter("@IsActiveAppointment", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        cmd.Parameters.Add(result);

                        conn.Open();
                        cmd.ExecuteScalar();

                        if (result != null)
                        {

                            activeAppointment =  Convert.ToBoolean(result);
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

            return activeAppointment;
        }
    }
}
