using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface IPermissionTypeService
    {
        DataTable GetPermissionTypes();
        List<(int TypeID, string Type, string Description)> GetPermissionTypeDetailsByID(int typeID);
        int GetPermissionTypeIDByName(string permissionTypeName);
    }
}
