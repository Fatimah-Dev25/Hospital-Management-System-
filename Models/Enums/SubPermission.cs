using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models.Enums
{
    public enum SubPermission
    {
        All = -1,
        Add = 1,
        Edit = 2, 
        Delete = 4,
        ViewItem = 8,
        ViewList = 16,
        ChangePassword = 32
    }
}
