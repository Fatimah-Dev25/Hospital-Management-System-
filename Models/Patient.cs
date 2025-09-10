using HospitalManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Patient
    {
        public int PatientId { get;  set; }
        public string FileNumber { get;  set; }
        public string Allergies { get; set; }
        public string ChronicDiseases { get; set; }
        public AdmissionStatus Status { get; set; }
        public int BloodTypeID { get; set; }   
        public int PersonID {  get; set; }
        public Person RelatedPerson { get; set; }

        public string BloodTypeName {  get; set; }

        public override string ToString()
        {
            return " - " + FileNumber + "       " + RelatedPerson.Fullname + ".";
                
        }
    }
}
