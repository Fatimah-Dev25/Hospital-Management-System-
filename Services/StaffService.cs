using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class StaffService : IStaffService
    {
        DepartmentService departmentService;

        public StaffService()
        {
            departmentService = new DepartmentService();
        }

        public int Add(StaffEntity entity, int userID)
        {
            return StaffRepository.AddStaff(entity.JobTitle, (int)entity.ShiftType, entity.DateHired, entity.PersonID,
                entity.DepartmentID, entity.isActive, userID);
        }

        public bool DeactivateEmployee(int employeeId, int userID)
        {
            return StaffRepository.DeactivateEmployee(employeeId, userID);
        }

        public bool Delete(int id, int userID)
        {
            return StaffRepository.DeleteStaff(id, userID);
        }

        public DataTable GetAll()
        {
            return StaffRepository.GetStaffList();
        }

        public StaffEntity GetById(int id)
        {
            DataTable dt = StaffRepository.GetStaffInfoByID(id);

            if (dt.Rows.Count > 0) {

                return new StaffEntity
                {
                    StaffId = (int)dt.Rows[0]["StaffID"],
                    JobTitle = dt.Rows[0]["JobTitle"].ToString(),
                    ShiftType = Enum.TryParse(dt.Rows[0]["ShiftType"].ToString(), out ShiftType st)
                    ? st
                    : ShiftType.None,
                    DateHired = Convert.ToDateTime(dt.Rows[0]["DateHired"]),
                    PersonID = (int)dt.Rows[0]["PersonID"],
                    DepartmentID = (int)dt.Rows[0]["DepartmentID"],
                    DeptText = dt.Rows[0]["Department"].ToString(),
                    isActive = dt.Rows[0]["IsActive"] != DBNull.Value && Convert.ToBoolean(dt.Rows[0]["IsActive"])

,                };
            }

            return null;
        }

        public bool Update(StaffEntity entity, int userID)
        {
            return StaffRepository.UpdateStaffInfo(entity.StaffId, entity.JobTitle, (int)entity.ShiftType, entity.DateHired,
                entity.PersonID, entity.DepartmentID, entity.isActive, userID);
        }
        public List<(int id, string department)> GetSupportDepartments()
        {
            DataTable dt = departmentService.GetAll();
            return dt.AsEnumerable()
                .Where(row => row.Field<string>("DepartmentType") == "Support")
                .Select(row => (
                    id: row.Field<int>("DeptID"),
                    department: row.Field<string>("Department")
                    )
                )
                .ToList();
        }

        public bool IsEmployeeExistsForPerson(int personID)
        {
            return StaffRepository.IsEmployeeExistsForPerson(personID);
        }

    }
}
