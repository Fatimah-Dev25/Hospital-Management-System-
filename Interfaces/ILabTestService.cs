using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface ILabTestService:IRepository<LabTest>
    {
        DataTable GetLabTestsListFilterd(int? recordID = null, int? patientID = null);

        bool UpdateLabTestResult(int labTestId, string result, int userID);
    }
}
