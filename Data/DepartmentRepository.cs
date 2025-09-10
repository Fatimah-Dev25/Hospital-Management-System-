using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data
{
    internal class DepartmentRepository
    {
        public static DataTable GetAllDepartments()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("GetAllDepartements", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {

                                dt.Load(reader);
                                DatabaseHelper.LogMessage("Fetched all Departments..", DatabaseHelper.EventType.Information);
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
        public static DataTable GetDepartmentByID(int deptID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("GetDepartementInfoByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@deptID", deptID);

                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {

                                dt.Load(reader);
                                DatabaseHelper.LogMessage($"Fetch Department with ID: {deptID}", DatabaseHelper.EventType.Information);
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
        public static int AddNewDepartment(string Department, int departmentTypeID, int userID)
        {
            int departmentID = -1;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("Add_Departement", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@departement", Department);
                        cmd.Parameters.AddWithValue("@departmentType", departmentTypeID);

                        var outputIdParam = new SqlParameter("@departementID", SqlDbType.Int)
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

                            departmentID = (int)outputIdParam.Value;
                            DatabaseHelper.LogMessage($"Department added successfully with ID: {departmentID}", DatabaseHelper.EventType.Information);

                        }
                        else
                        {
                            DatabaseHelper.LogMessage("Failed to retrieve DepartmentID after insert.", DatabaseHelper.EventType.Warning);

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



            return departmentID;
        }
        public static bool DeleteDepartment(int deptID, int deleteBy)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("DeleteDepartement", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@deptID", deptID);
                        var result = new SqlParameter("@rowsAffected", SqlDbType.Int);
                        result.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(result);

                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", deleteBy);
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
        public static bool UpdateDepartment(int deptID, string department, int departmentType, int updateBy)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("Update_Departement", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@deptID", deptID);
                        cmd.Parameters.AddWithValue("@departement", department);
                        cmd.Parameters.AddWithValue("@departmentType", departmentType);

                        var result = new SqlParameter("@rowsAffected", SqlDbType.Int);
                        result.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(result);

                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", updateBy);
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
