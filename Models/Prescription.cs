using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Prescription
    {
        public int PrescriptionId { get;  set; }
        public int MedicalRecordId { get; set; }
        public DateTime DateIssued { get; set; }
        public string PrescriptionText { get; set; }
        public double TotalPrice { get; set; }
        public int CreatedBy { get; set; }

        public string PrescriptionFor;

        public string PrescriptionOrderBy;

        public MedicalRecord RelatedMedicalRecord { get; set; }
    }
}
