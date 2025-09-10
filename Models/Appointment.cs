using HospitalManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Appointment
    {
        public int AppointementID { set; get;}
        public int DoctorID { set; get;}
        public int PatientID { set; get;}
        public DateTime AppointmentDate { set; get;}
        public TimeSpan AppointmentTime { set; get;}
        public DateTime LastUpdatedAt { set; get;}
        public DateTime CreatedAt { set; get;}
        public AppointmentType AppointmentType { set; get; }
        public AppointmentStatus AppointmentStatus { set; get;}
        public string Notes { set; get; }
        public int CreatedByUserID { set; get; }

        public string DoctorName;
        public string PatientName;
        public string PatientFile;

        public string Department;

        public MedicalRecord RelatedMedicalRecord { set; get; }
    }   

}
