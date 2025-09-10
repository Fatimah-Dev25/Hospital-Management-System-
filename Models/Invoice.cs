using HospitalManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Invoice
    {
        public int InvoiceID { get;  set; }
        public int MedicalRecordID { get; set; }
        public string ServiceDescription { get; set; }
        public double TotalAmount { get; set; }
        public DateTime InvoiceIssuedDate { get; set; }
        public InvoiceStatus Status { get; set; } = 0;

        public bool isDelete {  get; set; }
    }
}
