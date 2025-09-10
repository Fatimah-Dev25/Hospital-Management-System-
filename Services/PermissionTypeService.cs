using HospitalManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class PermissionTypeService
    {
        public List<(int ID, string Type, string Description)> GetPermissionTypes()
        {
            return PermissionTypeRepository.GetPermissionTypes();
        }

        public List<(int TypeID, string Type, string Description)> GetPermissionTypeDetailsByID(int TypeID)
        {
            return PermissionTypeRepository.GetPermissionTypeDetailsByID(TypeID);
        }

        public int GetPermissionTypeIDByName(string Name) { 
        
            return PermissionTypeRepository.GetPermissionTypeIDByName(Name);
        }
    }
}
