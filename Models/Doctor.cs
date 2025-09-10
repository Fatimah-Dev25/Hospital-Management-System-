using HospitalManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        public int DoctorID { get;  set; }
        public string Specialization { get; set; }
        public int ExperienceYears { get; set; }
        public DateTime DateHired { set; get; }
        public int PersonID { get; set; }   
        public int DepartmentID { get; set; }   
        public Person RelatedPerson {
            get;
            set; 
        }

        public string DepartmentTilte {  get; set; }

       
    }
}

