using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_AdminPanel.Models
{
    public class UserRole
    {
        [Key]
        public int UserRoleID { get; set; }
        
        
        public int UserID { get; set; }
        public IList<User> Rusers { get; set; }

        public int RoleID { get; set; }

        public IList<Roles> UserR { get; set; }

        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
