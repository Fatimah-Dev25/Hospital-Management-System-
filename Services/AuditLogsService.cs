using DocumentFormat.OpenXml.Spreadsheet;
using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    internal class AuditLogsService : IAuditLogService
    {
        public DataTable GetAuditLogByID(int logId)
        {
            return AudiLogsRepository.GetAuditLogDetailByID(logId);
        }

        public DataTable GetAuditLogsList()
        {
            return AudiLogsRepository.GetAuditLogsList();
        }

        public (int, int) GetDashboardDetails(string tableName, DateTime dayFilter)
        {
            return AudiLogsRepository.GetDashboardDetail(tableName, dayFilter);
        }

        public List<(int MonthNumber, int NumberOfPatients)> GetPatinetsCountInMonth()
        {
            DataTable dt = AudiLogsRepository.GetMonthlyPatientsCount();
            

            if (dt != null) {

                return dt.AsEnumerable().Select(row =>
                (MonthNumber: row.Field<int>("MonthNumber"),
                NumberOfPatients: row.Field<int>("PatientsCount"))).ToList();
            }

            return null;
        }
    }
}
