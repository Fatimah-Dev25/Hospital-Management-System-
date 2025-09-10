using HospitalManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class RolePermissions
    {
        public int RolePermissionId { get; set; }
        public int RoleId { get; set; }
        public GeneralPermissions PermissionType { get; set; }
        public int CombinedPermissionsValue { get; set; }
    }
}
