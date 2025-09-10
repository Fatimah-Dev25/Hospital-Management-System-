using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface IRolePermissionsService
    {
        DataTable GetUsersPermissionsList();
        List<(int pType, int pValue)> GetRolePermissions(int roleID);
        int GetRolePermissionsByType(int roleID, int permissionsTypeID);
        int GrantUserPermissions(int roleID, int permissionsTypeID, int combinedPermissionsValue, int userID);
        bool RevokeUserPermissions(int rolePermissionsID, int userID);
        bool UpdateUserPermissions(int newpermissionsValue, int rolePermissionsID, int userID);

        bool AddOrUpdateRolePermissions(int roleID, List<(int PermissionTypeID, int CombinePermissionValues)> updatePersmissions, int updatedBy);
        
    }
}
