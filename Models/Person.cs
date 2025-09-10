using HospitalManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Fullname { set;  get; }
        public DateTime BirthDate { get; set; }
        public string Phone {  set; get; }
        public string Email { set; get; }
        public GenderType Gender { set; get; } 
        public string Address { set; get; }
        public bool isDeleted { set; get; }
        public string ImagePath { set; get; }
  
    }
}
