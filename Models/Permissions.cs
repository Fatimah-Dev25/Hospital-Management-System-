using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Permissions
    {
        public int PermissionID { get; set; }
        public string PermissionName { get; set; }
        public int PermissionTypeID { get; set; }
        public int Value { get; set; }
   
        public PermissionType PermissionType { get; set; }
    }
}
