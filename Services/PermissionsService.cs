using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class PermissionsService : IPermissionsService
    {
        public DataTable GetPermissionDetailsByID(int permissionID)
        {
            return PermissionRepository.GetPermissionDetailsByID(permissionID);
        }

        public DataTable GetPermissionsList()
        {
            return PermissionRepository.GetPermissionsList();
        }

        public List<(int PermissionID, string Permission, int PermissionValue)> GetPermissionsListByTypeID(int permissionType)
        {
            return PermissionRepository.GetPermissionsListByTypeID(permissionType);
        }
    }
}
