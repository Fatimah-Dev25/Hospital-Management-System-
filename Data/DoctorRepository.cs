using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data
{
    internal static class DoctorRepository
    {
        public static int AddDoctor(string specialization, int experienceYears, DateTime dateHired, int personID, int deptID, int userID)
        {
            int doctorID = -1;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("AddDoctor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@specialization", specialization);
                        cmd.Parameters.AddWithValue("@experienceYears", experienceYears);
                        cmd.Parameters.AddWithValue("@dateHired", dateHired);
                        cmd.Parameters.AddWithValue("@personID", personID);
                        cmd.Parameters.AddWithValue("@deptID", deptID);
                    

                        var outputIdParam = new SqlParameter("@DoctorID", SqlDbType.Int)
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

                            doctorID = (int)outputIdParam.Value;
                            DatabaseHelper.LogMessage($"Doctor added successfully with ID: {doctorID}", DatabaseHelper.EventType.Information);

                        }
                        else
                        {
                            DatabaseHelper.LogMessage("Failed to retrieve DoctorID after insert.", DatabaseHelper.EventType.Warning);

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

            return doctorID;
        }
        public static bool DeleteDoctor(int doctorID, int userID)
        {
            bool isDelete = false;

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("DeleteDoctor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@doctorID", doctorID);
                        var rowsAffacted = new SqlParameter("@rowsAffected", SqlDbType.Int)
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
                        isDelete =  (int)rowsAffacted.Value > 0;

                        DatabaseHelper.LogMessage($"Doctor deleted successfully. ID: {doctorID}", DatabaseHelper.EventType.Information);
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
        public static DataTable GetDoctorsList()
        {

            DataTable result = new DataTable();

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("GetAllDoctors", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                                result.Load(reader);

                            DatabaseHelper.LogMessage("Fetched all doctors..", DatabaseHelper.EventType.Information);


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
        public static DataTable GetDoctorByID(int doctorID)
        {

            DataTable result = new DataTable();
           
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("GetDoctorDetailsByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@doctorID", doctorID);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                result.Load(reader);
                                DatabaseHelper.LogMessage($"Fetched Doctor by ID {doctorID}", DatabaseHelper.EventType.Information);

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
        public static bool UpdateDoctor(int doctorID, string specialization, int experienceYears, DateTime dateHired, int deptID, int userID)
        {

            bool isUpdated = false;

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("UpdateDoctor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@doctorID", doctorID);
                        cmd.Parameters.AddWithValue("@specialization", specialization);
                        cmd.Parameters.AddWithValue("@experienceYears", experienceYears);
                        cmd.Parameters.AddWithValue("@dateHired", dateHired);
                        cmd.Parameters.AddWithValue("@deptID", deptID);

                        var rowsAffacted = new SqlParameter("@rowsAffected", SqlDbType.Int)
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
                        
                        isUpdated =  (int)rowsAffacted.Value > 0;

                        DatabaseHelper.LogMessage($"Doctor updated successfully. ID: {doctorID}", DatabaseHelper.EventType.Information);
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
        public static DataTable GetDepartementDoctors(int deptID)
        {
            DataTable dt = new DataTable();

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("GetDepartementDoctors", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@deptID", deptID);
                     
                        conn.Open();

                        using (var reader = cmd.ExecuteReader()) {

                            if (reader.HasRows) {
                            
                                dt.Load(reader);

                                DatabaseHelper.LogMessage($"Fetch Doctors List in Department with ID {deptID} ..", DatabaseHelper.EventType.Information);
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

        public static bool IsDoctorExistsForPerson(int personID)
        {
            bool exists = false;

            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_IsDoctorExistsForPerson", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@personId", personID);

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

        public static DataTable GetDoctorsID()
        {

            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_GetDoctorsID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                result.Load(reader);

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

    }
}
