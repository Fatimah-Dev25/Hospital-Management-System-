using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class RolePermissionsService : IRolePermissionsService
    {
        public bool AddOrUpdateRolePermissions(int roleID, List<(int PermissionTypeID, int CombinePermissionValues)> updatePersmissions, int updatedBy)
        {
            return RolePermissionsRepository.AddOrUpdateRolePermissions(roleID, updatePersmissions, updatedBy);
        }

        public List<(int pType, int pValue)> GetRolePermissions(int roleID)
        {
            return RolePermissionsRepository.GetRolePermissions(roleID);
        }

        public int GetRolePermissionsByType(int roleID, int permissionsTypeID)
        {
            return RolePermissionsRepository.GetRolePermissionsByType(roleID, permissionsTypeID);
        }

        public DataTable GetUsersPermissionsList()
        {
            return RolePermissionsRepository.GetUsersPermissionsList();
        }

        public int GrantUserPermissions(int roleID, int permissionsTypeID, int combinedPermissionsValue, int userID)
        {
            return RolePermissionsRepository.GrantUserPermissions(roleID, permissionsTypeID, combinedPermissionsValue, userID); 
        }

        public bool RevokeUserPermissions(int rolePermissionsID, int userID)
        {
            return RolePermissionsRepository.RevokeUserPermissions(rolePermissionsID, userID);
        }

        public bool UpdateUserPermissions(int newpermissionsValue, int rolePermissionsID, int userID)
        {
            return RolePermissionsRepository.UpdateUserPermissions(rolePermissionsID, newpermissionsValue, userID);
        }
    }
}
