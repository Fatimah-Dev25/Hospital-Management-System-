using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models.Enums
{
    public enum AuditLogsPermissions
    {
        All = -1,
        ViewLogs = 1,
        ViewLogDetail = 2,
        ExportToPDF = 4
    }
}
