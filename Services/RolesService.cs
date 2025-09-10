using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class RolesService : IRoleService
    {
        public List<(int RoleID, string Role)> GetAllUsersRole()
        {
            return RoleRepository.GetAllUsersRole();
        }

        public string GetRoleByID(int roleID)
        {
            return RoleRepository.GetRoleByID(roleID);
        }

        public bool UpdateRole(int roleID, string roleName, int updatedBy)
        {
            return RoleRepository.UpdateRole(roleID, roleName, updatedBy);
        }
    }
}
