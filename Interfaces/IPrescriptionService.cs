using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface IPrescriptionService:IRepository<Prescription>
    {
        DataTable GetPrescriptionsByPatientID(int patientID);   

        DataTable GetPrescriptionsByRecordID(int recordID);
    }
}
