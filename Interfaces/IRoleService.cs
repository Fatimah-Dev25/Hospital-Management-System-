using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface IRoleService
    {
        List<(int RoleID, string Role)> GetAllUsersRole();

        string GetRoleByID(int roleID);

        bool UpdateRole(int  roleID, string roleName, int updatedBy);
    }
}
