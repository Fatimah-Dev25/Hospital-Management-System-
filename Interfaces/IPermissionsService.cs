using HospitalManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface IPermissionsService
    {
        DataTable GetPermissionsList();
        List<(int PermissionID, string Permission, int PermissionValue)> GetPermissionsListByTypeID(int permissionType);

        DataTable GetPermissionDetailsByID(int permissionID);
    }
}
