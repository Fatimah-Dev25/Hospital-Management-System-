using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class LabTest
    {
        public int LabTestID { get; set; }
        public int MedicalRecordID { get; set; }
        public int TestTypeID { get; set; }
        public DateTime TestDate { get; set; }
        public string Result { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsDeleted { get; set; }

        public string TestName;

        public MedicalRecord RelatedMedicalRecord { get; set; }
    
        public TestType RelatedTestType { get; set; }
    }
}
