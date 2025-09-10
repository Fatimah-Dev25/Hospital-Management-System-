using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models.Enums
{
    public enum InvoicePermissions
    {
        All = -1,
        IssueInvoice = 1,
        Edit = 2,
        ApplyDiscount = 4,
        ViewItem = 8,
        ViewAll = 16,
        PayInvoice = 32,
        CancelInvoice = 64,
        ViewInvoiceHistory = 128
    }
}
