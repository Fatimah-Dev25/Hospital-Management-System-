using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class InvoiceItem
    {
        public int InvoiceItemID { get; set; }
        public int InvoiceID { get; set; }
        public int ItemID { get; set; }
        public string ItemType { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }


    }
}
