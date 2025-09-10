using HospitalManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Department
    {
        public int DeptID { get; private set; }
        public string DepartmentName { set; get; }
        public DepartmentType DepartmentType { set; get; }


    }
}
