using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface IAuditLogService
    {
        (int, int) GetDashboardDetails(string tableName, DateTime dayFilter);

        List<(int MonthNumber, int NumberOfPatients)> GetPatinetsCountInMonth();

        DataTable GetAuditLogsList();

        DataTable GetAuditLogByID(int logId);
    }
}
