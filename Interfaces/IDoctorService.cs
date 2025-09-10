using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface IDoctorService:IRepository<Doctor>
    {
        DataTable GetDepartementDoctors(int DeptID);
    }
}
