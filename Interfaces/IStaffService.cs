using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface IStaffService:IRepository<StaffEntity>
    {
        bool DeactivateEmployee(int employeeId, int userID);
    }
}
