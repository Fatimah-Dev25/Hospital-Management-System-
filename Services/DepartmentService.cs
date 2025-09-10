using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class DepartmentService : IRepository<Department>
    {
        public int Add(Department entity, int userID)
        {
            return DepartmentRepository.AddNewDepartment(entity.DepartmentName, (int)entity.DepartmentType, userID);
        }

        public bool Delete(int id, int userID)
        {
            return DepartmentRepository.DeleteDepartment(id, userID);
        }

        public DataTable GetAll()
        {
            return DepartmentRepository.GetAllDepartments();
        }

        public Department GetById(int id)
        {
            //return DepartmentRepository.GetDepartmentByID(id).Rows[0];

            return null;
        }

        public bool Update(Department entity, int userID)
        {
            return DepartmentRepository.UpdateDepartment(entity.DeptID, entity.DepartmentName, (int)entity.DepartmentType, userID);
        }
    }
}
