using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data
{
    public static class AudiLogsRepository
    {

        public static DataTable GetAuditLogsList()
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetAuditLogsList", conn))
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
        public static DataTable GetAuditLogDetailByID(int logId)
        {
            DataTable result = new DataTable();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetLogDetailByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@logID", logId);

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

        public static (int TodayResult, int YesterdayResult) GetDashboardDetail(string table, DateTime DayFilter)
        {
        
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetDashboardDetail", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@tableName", table);
                        cmd.Parameters.AddWithValue("@dateOfInsertion", DayFilter);

                        var todayResult = new SqlParameter("@countOfTodayEntities", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        var yesterdayResult = new SqlParameter("@countOfYesterdayEntities", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output,
                        };

                        cmd.Parameters.Add(todayResult);
                        cmd.Parameters.Add(yesterdayResult);
                        
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        return ((int)todayResult.Value, (int)yesterdayResult.Value);
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

            return (0, 0);
        }

    
        public static DataTable GetMonthlyPatientsCount()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    using (var cmd = new SqlCommand("SP_GetMonthlyPatientsCount", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        conn.Open();

                        using (var reader = cmd.ExecuteReader()) { 
                        
                            if(reader.HasRows)
                                dt.Load(reader);
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

            return dt;

        }
    }
}
