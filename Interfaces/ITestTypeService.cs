using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface ITestTypeService:IRepository<TestType>
    {
        bool ChangeTestTypeActivation(int testTypeID, bool isActive, int userID);

        List<TestType> GetTypesList();
    }
}
