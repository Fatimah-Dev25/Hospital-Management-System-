using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    internal interface IPatientService:IRepository<Patient>
    {
        int isPatientExits(int patientID = 0, string patientFile = null);

        List<Patient> GetLatestPatients(int count = 5);
    }
}
