using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data
{
    internal static class PrescriptionRepository
    {

        public static DataTable GetPrescriptionsList()
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetPrescriptionsList", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                result.Load(reader);

                            DatabaseHelper.LogMessage("Fetched Prescriptions List", DatabaseHelper.EventType.Information);
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
        public static DataTable GetPrescriptionsByPatientID(int patientID)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetPrescriptionsByPatientID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@patientID", patientID);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                result.Load(reader);

                            DatabaseHelper.LogMessage($"Fetched Prescriptions for Patient with ID {patientID}.", DatabaseHelper.EventType.Information);
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
        public static DataTable GetPrescriptionsByRecordID(int recordID)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetPrescriptionsByMedicalRecord", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@recordID", recordID);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                result.Load(reader);

                            DatabaseHelper.LogMessage($"Fetched Prescriptions related Medical Record with ID {recordID}.", DatabaseHelper.EventType.Information);
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
        public static DataTable GetPrescriptionByID(int prescriptionID)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetPrescriptionsByPrescriptionID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prescriptionID", prescriptionID);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                result.Load(reader);

                            DatabaseHelper.LogMessage($"Fetched Prescription with ID {prescriptionID} details.", DatabaseHelper.EventType.Information);
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
        public static int AddPrescription(int recordID, string prscriptionTxt, double totalPrice, int createdby)
        {
            int prescriptionID = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_AddPrescription", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@recordID", recordID);
                        cmd.Parameters.AddWithValue("@prescriptionTxt", prscriptionTxt);
                        cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                        cmd.Parameters.AddWithValue("@userCreated", createdby);


                        var outputIdParam = new SqlParameter("@prescriptionID", SqlDbType.Int)
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
                            prescriptionID = (int)outputIdParam.Value;
                            DatabaseHelper.LogMessage($"Prescription added successfully with ID: {prescriptionID}", DatabaseHelper.EventType.Information);
                        }
                        else
                        {
                            DatabaseHelper.LogMessage("Failed to retrieve Prescription after insert.", DatabaseHelper.EventType.Warning);
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

            return prescriptionID;
        }
        public static bool DeletePrescription(int prescriptionID, int userID)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_DeletePrescription", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@prescriptionID", prescriptionID);
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

                        DatabaseHelper.LogMessage($"Prescription deleted successfully. ID: {prescriptionID}", DatabaseHelper.EventType.Warning);
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
        public static bool UpdatePrescription(int prescriptionID, string prescriptionTxt, double totalPrice, int userID)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_UpdatePrescription", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@prescriptionID", prescriptionID);
                        cmd.Parameters.AddWithValue("@prescriptionTxt", prescriptionTxt);
                        cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                

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

                        DatabaseHelper.LogMessage($"Prescription updated successfully. ID: {prescriptionID}", DatabaseHelper.EventType.Information);
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
