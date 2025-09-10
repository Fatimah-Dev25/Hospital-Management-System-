using DocumentFormat.OpenXml.ExtendedProperties;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagementSystem.Data
{
    internal static class AttachmentsRepository
    {

        public static DataTable GetAllAttachments()
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetAllAttachments", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

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
        public static DataTable GetAttachmentByRelatedInfo(string relatedTable, int recordID)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetAttachmentsByRelatedInfo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@RelatedTable", relatedTable);
                        cmd.Parameters.AddWithValue("@RelatedId", recordID);
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
        public static DataTable GetAttachmentByID(int attachmentID)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetAttachmentByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@AttachmentId", attachmentID);
                       
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
        public static int AddAttachment(string relatedTable, int relatedRecord, string fileName,
            string filePath, int createdBy)
        {
            int attachmentID = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_AddAttachment", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@RelatedTable", relatedTable);
                        cmd.Parameters.AddWithValue("@RelatedId", relatedRecord);
                        cmd.Parameters.AddWithValue("@FileName", fileName);
                        cmd.Parameters.AddWithValue("@FilePath", filePath);
                 
                   
                        var outputIdParam = new SqlParameter("@AttachmentId", SqlDbType.Int)
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
                            attachmentID = (int)outputIdParam.Value;
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

            return attachmentID;
        }

        public static bool DeleteAttachmentByID(int attachmentID, int userID)
        {
            bool isDeleted = false;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_DeleteAttachmentByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@AttachmentId", attachmentID);

                        var result = new SqlParameter("@rowsAffacted", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
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

                        isDeleted = (Convert.ToInt32(result.Value)) > 0;

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

            return isDeleted;
        }

        public static bool DeleteAttachmentByRelatedInfo(string relatedTable, int recordID, int userID)
        {
            bool isDeleted = false;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_DeleteAttachmentByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@RelatedTable", relatedTable);
                        cmd.Parameters.AddWithValue("@RelatedId", recordID);

                        var result = new SqlParameter("@rowsAffacted", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
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

                        isDeleted = (Convert.ToInt32(result.Value)) > 0;

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

            return isDeleted;
        }

        public static bool UpdateAttachment(int attachmentId, string fileName, string filePath, int updatedBy)
        {
            bool isUpdated = false;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_UpdateAttachmentByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@AttachmentId", attachmentId);
                        cmd.Parameters.AddWithValue("@FileName", fileName);
                        cmd.Parameters.AddWithValue("@FilePath", filePath);
        

                        var rowsAffacted = new SqlParameter("@rowsAffacted", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        cmd.Parameters.Add(rowsAffacted);

                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", updatedBy);
                            contextCmd.ExecuteNonQuery();
                        }

                        cmd.ExecuteNonQuery();

                        isUpdated = (int)rowsAffacted.Value > 0;

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
    }
}
