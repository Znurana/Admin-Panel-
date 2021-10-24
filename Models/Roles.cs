using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_AdminPanel.Models
{
    public class Roles
    {
        [Key]
        public int RoleID { get; set; }
        public virtual UserRole UserRole { get; set; }
        

        public string RoleName { get; set; }
    }
}
