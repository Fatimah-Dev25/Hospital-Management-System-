using HospitalManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class StaffEntity
    {
        public int StaffId { get;  set; }    
        public string JobTitle { get; set; }    
        public ShiftType ShiftType { get; set; }    
        public DateTime DateHired { get; set; }
        public int PersonID { get; set; }
        public int DepartmentID { get; set; }
        public bool isActive {  get; set; }
        public Person RelatedPerson { get; set; }

        public string DeptText;
    }
}
