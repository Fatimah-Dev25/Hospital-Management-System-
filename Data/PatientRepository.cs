using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data
{
    internal static class PatientRepository
    {
        public static int AddPatient(int personID, string fileNumber, string allergies, string chronicDiseases, int admissionStatus, int bloodTypeID,
            int userID)
        {
            int patientID = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("AddPatient", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@personID", personID);
                        cmd.Parameters.AddWithValue("@fileNumber", fileNumber);
                        cmd.Parameters.AddWithValue("@allergies", allergies);
                        cmd.Parameters.AddWithValue("@chronicDiseases", chronicDiseases);
                        cmd.Parameters.AddWithValue("@admissionStatus", admissionStatus);
                        cmd.Parameters.AddWithValue("@bloodType", bloodTypeID);


                        var outputIdParam = new SqlParameter("@patientID", SqlDbType.Int)
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

                            patientID = (int)outputIdParam.Value;
                            DatabaseHelper.LogMessage($"Patient added successfully with ID: {personID}", DatabaseHelper.EventType.Information);

                        }
                        else
                        {
                            DatabaseHelper.LogMessage("Failed to retrieve PatientID after insert.", DatabaseHelper.EventType.Warning);

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

            return patientID;
        }
        public static bool DeletePatient(int patientID, int userID)
        {
            bool isDelete = false;

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("DeletePatient", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@patientID", patientID);
                    
                        var result = new SqlParameter("@rowsAffected", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(result);

                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", userID);
                            contextCmd.ExecuteNonQuery();
                        }
                        cmd.ExecuteNonQuery();
                        isDelete =  (int)result.Value > 0;

                        DatabaseHelper.LogMessage($"Patient deleted successfully. ID: {patientID}", DatabaseHelper.EventType.Information);
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
        public static DataTable GetAllPatients()
        {

            DataTable result = new DataTable();

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("GetAllPatients", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                result.Load(reader);
                                DatabaseHelper.LogMessage("Fetched all patients", DatabaseHelper.EventType.Information);
                            }
                            else
                            {
                                DatabaseHelper.LogMessage("Failed to retrieve patients", DatabaseHelper.EventType.Error);
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
        public static DataTable GetLatestPatients(int count = 5)
        {

            DataTable result = new DataTable();

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_GetLatestPatients", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@count", count);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                result.Load(reader);
                                DatabaseHelper.LogMessage("Fetched all patients", DatabaseHelper.EventType.Information);
                            }
                            else
                            {
                                DatabaseHelper.LogMessage("Failed to retrieve patients", DatabaseHelper.EventType.Error);
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
        public static DataTable GetPatientByID(int patientID)
        {

            DataTable result = new DataTable();
            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("GetPatientDetailsByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@patientID", patientID);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                result.Load(reader);
                                DatabaseHelper.LogMessage($"Fetched Patient by ID {patientID}", DatabaseHelper.EventType.Information);

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
        public static bool UpdatePatient(string allergies, string chronicDiseases, int admissionStatus,
            int bloodTypeID, int patientID, int userID)
        {

            bool isUpdated = false;

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("UpdatePatient", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@allergies", allergies);
                        cmd.Parameters.AddWithValue("@chronicDiseases", chronicDiseases);
                        cmd.Parameters.AddWithValue("@admissionStatus", admissionStatus);
                        cmd.Parameters.AddWithValue("@bloodTypeID", bloodTypeID);
                        cmd.Parameters.AddWithValue("@patientID", patientID);

                        var result = new SqlParameter("@rowsAffacted", DbType.Int32)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(result);

                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", userID);
                            contextCmd.ExecuteNonQuery();
                        }
                        cmd.ExecuteNonQuery();
                        isUpdated =  (int)result.Value > 0;

                        DatabaseHelper.LogMessage($"Patient updated successfully. ID: {patientID}", DatabaseHelper.EventType.Information);
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

        public static bool IsPatientExistsForPerson(int personID)
        {
            bool exists = false;

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_IsPatientExistsForPerson", conn))
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

        public static int isPatientExits(int patientID = 0, string patientFile = null)
        {
            int returnedID = 0;

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_IsPatientExists", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (patientID != 0)
                            cmd.Parameters.AddWithValue("@patientID", patientID);
                        else
                            cmd.Parameters.AddWithValue("@patientID", DBNull.Value);

                        if(patientFile != null)
                            cmd.Parameters.AddWithValue("@fileNumber", patientFile);
                        else
                            cmd.Parameters.AddWithValue("@fileNumber", DBNull.Value);

                        conn.Open();
                        object result = cmd.ExecuteScalar();

                        if(result != null)
                            returnedID = Convert.ToInt32(result);
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

            return returnedID;
        }
    }
}
