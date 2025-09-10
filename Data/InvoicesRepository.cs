using HospitalManagementSystem.Models;
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
    internal static class InvoicesRepository
    {
        public static DataTable GetInvoicesList()
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetInvoicesList", conn))
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
        public static DataTable GetInvoicePaymentsList(int invoiceID)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetInvoicePaymentsByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@invoiceID", invoiceID);

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
        public static DataTable GetInvoicesByPatientID(int patientID)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("GetInvoicesByPatientID", conn))
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
        public static DataTable GetInvoiceItems(int invoiceID)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetInvoiceItems", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@invoiceId", invoiceID);
                        
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
        public static DataTable GetInvoiceDetailById(int invoiceID)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetInvoiceDetailByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@invoiceID", invoiceID);

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
        public static DataTable GetInvoicesByMedicalRecord(int recordID)    
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetInvoicesByRecordID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@recordID", recordID);

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
        public static int IssueInvoic(int recordID, string serviceDescription, int status, int userID)
        {
            int InvoiceID = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_IssueInvoice", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@RecordID", recordID);
                        if(string.IsNullOrEmpty(serviceDescription))
                             cmd.Parameters.AddWithValue("@ServiceDescription", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@ServiceDescription", serviceDescription);
                        
                        cmd.Parameters.AddWithValue("@Status", status);

                    
                        var outputIdParam = new SqlParameter("@InvoiceID", SqlDbType.Int)
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
                            InvoiceID = (int)outputIdParam.Value;
                            DatabaseHelper.LogMessage($"Bill added successfully with ID: {InvoiceID}", DatabaseHelper.EventType.Information);
                        }
                        else
                        {
                            DatabaseHelper.LogMessage("Failed to retrieve BillID after insert.", DatabaseHelper.EventType.Warning);
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

            return InvoiceID;
        }
        public static bool DeleteInvoice(int invoiceID, int userID)
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_DeleteInvoice", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@invoiceID", invoiceID);

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

                        DatabaseHelper.LogMessage($"Bill deleted successfully. ID: {invoiceID}", DatabaseHelper.EventType.Warning);
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
        public static bool UpdateInvoiceInfo(int invoiceID, double totalAmount, int userID, string serviceDescription = "")
        {
            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_UpdateInvoiceInfo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@invoiceID", invoiceID);

                        if(string.IsNullOrEmpty(serviceDescription))
                            cmd.Parameters.AddWithValue("@newDescription", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@newDescription", serviceDescription);
                        
                        cmd.Parameters.AddWithValue("@NewAmount", totalAmount);
                     

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
        public static DataTable GetPatientInfoByInvoiceID(int invoiceID)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetPatientInfoByInvoiceID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@invoiceID", invoiceID);

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

        public static DataTable GetInvoiceItemInfoByID(int invoiceItemID)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetInvoiceItemDetailByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@invoiceItemID", invoiceItemID);

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
        public static bool UpdateInvoiceItemByID(int invoiceItemID, string itemType, string description, double price, int userID)
        {

            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_UpdateInvoiceItem", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@invoiceItemID", invoiceItemID);
                        cmd.Parameters.AddWithValue("@itemType", itemType);

                        if (string.IsNullOrEmpty(description))
                            cmd.Parameters.AddWithValue("@description", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@description", description);

                        cmd.Parameters.AddWithValue("@price", price);


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
    
        public static bool DeleteInvoiceItemByID(int invoiceItemID, int userID)
        {

            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_DeleteInvoicItem", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@invoiceItemID", invoiceItemID);



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

        public static bool UpdateInvoiceStatusByID(int invoiceID, int invoiceStatus, int userID)
        {

            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_UpdateInvoiceStatus", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
                        cmd.Parameters.AddWithValue("@invoiceStatus", invoiceStatus);



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


        public static bool UpdateInvoiceDescriptionByID(int invoiceID, string description, int userID)
        {

            int rowsAffacted = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_UpdateInvoiceDescription", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
                        cmd.Parameters.AddWithValue("@newDescription", description);



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


        public static int PerformPayment(int invoiceID, int status, double amountPaid, int paymentMethod, int entredByID)
        {
            int PaymentID = 0;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_PayInvoice", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@paidAmount", amountPaid);
                        cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);
                        cmd.Parameters.AddWithValue("@entryBy", entredByID);


                        var outputIdParam = new SqlParameter("@paymentID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputIdParam);

                        conn.Open();
                        using (var contextCmd = new SqlCommand("EXEC sp_set_session_context @key, @value", conn))
                        {
                            contextCmd.Parameters.AddWithValue("@key", "UserId");
                            contextCmd.Parameters.AddWithValue("@value", entredByID);
                            contextCmd.ExecuteNonQuery();
                        }

                        cmd.ExecuteNonQuery();

                        if (outputIdParam.Value != DBNull.Value)
                        {
                            PaymentID = (int)outputIdParam.Value;
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

            return PaymentID;
        }

    }
}
