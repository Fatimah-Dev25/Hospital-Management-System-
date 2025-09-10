using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HospitalManagementSystem.Data.DatabaseHelper;

namespace HospitalManagementSystem.Data
{
        internal static class PersonRepository
        {
            public static int AddPerson(string fullName, DateTime birthDate, string phone, string email, 
                char gender, string address, string imagePath, int userID)
            {
                int personID = 0;

                try
                {
                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        using (var cmd = new SqlCommand("Add_Person", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@fullName", fullName);
                            cmd.Parameters.AddWithValue("@birthDate", birthDate);
                            cmd.Parameters.AddWithValue("@phone", phone);
                        
                            if (email != null)
                                cmd.Parameters.AddWithValue("@email", email);
                            else
                                cmd.Parameters.AddWithValue("@email", DBNull.Value);

                            cmd.Parameters.AddWithValue("@address", address);
                            cmd.Parameters.AddWithValue("@gender", Char.ToUpper(gender));
                        
                            if (!string.IsNullOrEmpty(imagePath))
                               cmd.Parameters.AddWithValue("@image", imagePath);
                            else
                               cmd.Parameters.AddWithValue("@image", DBNull.Value);

                            var outputIdParam = new SqlParameter("@PersonID", SqlDbType.Int)
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

                                personID = (int)outputIdParam.Value;
                                DatabaseHelper.LogMessage($"Person added successfully with ID: {personID}", DatabaseHelper.EventType.Information);

                            }
                            else
                            {
                                DatabaseHelper.LogMessage("Failed to retrieve PersonID after insert.", DatabaseHelper.EventType.Warning);

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

                return personID;
            }
            public static bool DeletePerson(int personID, int userID)
            {
                bool isDelete = false;

                try
                {

                    using (var conn = DatabaseHelper.GetConnection())
                    {

                        using (var cmd = new SqlCommand("Delete_Person", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@PersonID", personID);

                            conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", userID);
                            contextCmd.ExecuteNonQuery();
                        }
                        isDelete = cmd.ExecuteNonQuery() > 0;

                            DatabaseHelper.LogMessage($"Person deleted (logical) successfully. ID: {personID}", DatabaseHelper.EventType.Warning);
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
            public static DataTable GetAllPeople()
            {

                DataTable result = new DataTable();

                try
                {

                    using (var conn = DatabaseHelper.GetConnection())
                    {

                        using (var cmd = new SqlCommand("GetAllPeople", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            conn.Open();
                            using (var reader = cmd.ExecuteReader())
                            {

                                if (reader.HasRows)
                                    result.Load(reader);

                                DatabaseHelper.LogMessage("Fetched all persons", DatabaseHelper.EventType.Information);


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
            public static DataTable GetPersonByID(int personID) {
            
                DataTable result = new DataTable();
                try
                {

                    using (var conn = DatabaseHelper.GetConnection())
                    {

                        using (var cmd = new SqlCommand("GetPersonByID", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@personID", personID);
                        
                            conn.Open();
                            using (var reader = cmd.ExecuteReader())
                        { 
                            
                               if (reader.HasRows)
                                {
                                    result.Load(reader);
                           
                             //   DatabaseHelper.LogMessage($"{name}, {phone}", DatabaseHelper.EventType.Information);

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
        public static DataTable GetPersonByName(string name)
        {

            DataTable result = new DataTable();
            try
            {

                using (var conn = DatabaseHelper.GetConnection())
                {

                    using (var cmd = new SqlCommand("SP_GetPersonByName", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@name", name);

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
        public static bool UpdatePerson(int personID, string fullName, DateTime birthDate, string phone, 
                string email, char gender, string address, string imagePath, int userID) {

                int rowsAffacted = 0;

                try
                {

                    using (var conn = DatabaseHelper.GetConnection())
                    {

                        using (var cmd = new SqlCommand("UpdatePerson", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@personID", personID);
                            cmd.Parameters.AddWithValue("@fullname", fullName);
                            cmd.Parameters.AddWithValue("@birthDate", birthDate);
                            cmd.Parameters.AddWithValue("@phone", phone);

                        if (!string.IsNullOrEmpty(email))
                            cmd.Parameters.AddWithValue("@email", email);
                        else
                            cmd.Parameters.AddWithValue("@email", DBNull.Value);
                            
                            cmd.Parameters.AddWithValue("@gender", gender);
                            cmd.Parameters.AddWithValue("@address", address);

                        if (!string.IsNullOrEmpty(imagePath))
                            cmd.Parameters.AddWithValue("@imagePath", imagePath);
                        else
                            cmd.Parameters.AddWithValue("@imagePath", DBNull.Value);

                        var result = new SqlParameter("@rowsAffected", SqlDbType.Int);
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

                        DatabaseHelper.LogMessage($"Person updated successfully. ID: {personID}", DatabaseHelper.EventType.Information);
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
