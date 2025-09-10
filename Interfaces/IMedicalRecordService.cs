using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface IMedicalRecordService:IRepository<MedicalRecord>
    {
        int IssueRecord(MedicalRecord record, int appointmentID);
        DataTable GetPatientRecords(int patientID);
        bool CheckRecordExits(int recordID);

        bool CheckRecordHasActiveAppoitment(int recordID);
    }
}
