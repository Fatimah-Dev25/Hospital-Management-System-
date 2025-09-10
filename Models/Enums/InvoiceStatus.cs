using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models.Enums
{
    public enum InvoiceStatus
    {
        Unpaid = 0,
        FullyPaid = 1,
        Cancelled = 2,
        PartiallyPaid = 3,
        Disputed = 4
    }
}
