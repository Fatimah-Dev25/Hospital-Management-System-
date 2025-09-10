using HospitalManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Utilities
{
    public static class PermissionManager
    {
        public static List<(GeneralPermissions PermType, int CombineValues)> CurrentUserPermissions;

        public static bool HasPermission(GeneralPermissions generalPerm, SubPermission subPerm)
        {
            if(CurrentUserPermissions.Any(p => p.PermType == GeneralPermissions.All))
                return true;

            var perm = CurrentUserPermissions.FirstOrDefault(p => p.PermType == generalPerm);

            if (perm.PermType == 0)
                return false;

            if (perm.CombineValues == (int)SubPermission.All)
                return true;

            return (perm.CombineValues & (int)subPerm) == (int)subPerm;
        }

        public static bool HasInvoicePermission(InvoicePermissions invoicePerm)
        {
            if (CurrentUserPermissions.Any(p => p.PermType == GeneralPermissions.All))
                return true;

            var perm = CurrentUserPermissions.FirstOrDefault(p => p.PermType == GeneralPermissions.BillingPermissions);

            if (perm.PermType == 0)
                return false;

            if (perm.CombineValues == (int)InvoicePermissions.All)
                return true;

            return (perm.CombineValues & (int)invoicePerm) == (int)invoicePerm;
        }

        public static bool HasAuiditLogsPermission(AuditLogsPermissions auditPerm)
        {
            if (CurrentUserPermissions.Any(p => p.PermType == GeneralPermissions.All))
                return true;

            var perm = CurrentUserPermissions.FirstOrDefault(p => p.PermType == GeneralPermissions.LoggingAuditingPermissions);

            if (perm.PermType == 0)
                return false;

            if (perm.CombineValues == (int)SubPermission.All)
                return true;

            return (perm.CombineValues & (int)auditPerm) == (int)auditPerm;
        }

        public static bool HasManageRolePermission(ManageRolePermissions rolePerm)
        {
            if (CurrentUserPermissions.Any(p => p.PermType == GeneralPermissions.All))
                return true;

            var perm = CurrentUserPermissions.FirstOrDefault(p => p.PermType == GeneralPermissions.UserRolesPermissions);

            if (perm.PermType == 0)
                return false;

            if (perm.CombineValues == (int)SubPermission.All)
                return true;

            return (perm.CombineValues & (int)rolePerm) == (int)rolePerm;
        }

    }
}
