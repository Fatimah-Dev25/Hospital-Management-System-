using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class User
    {
        public int UsertId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int PersonID { get; set; }
        public DateTime CreatedAt { get; set; }
        public int RoleID { get; set; }
        public bool IsActive { get; set; }
  
        public Person RelatedPerson { get; set; }

        public string Role;
    }
}
