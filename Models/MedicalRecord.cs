using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class MedicalRecord
    {
        public int RecordID { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public DateTime RecordDate { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public string Department;
        public string PatientName;
        public string DoctorName;

        public Patient RelatedPatient { get; set; }
    }
}
