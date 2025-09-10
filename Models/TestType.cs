using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class TestType
    {
        public int TestTypeID { get; set; }
        public string TestTypeName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool isActive { get; set; }
    
    }
}
