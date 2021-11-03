using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_AdminPanel.Models
{
    public class Role
    {

        [Key]
        public int RoleID { get; set; }

        public string RoleName { get; set; }
        public ICollection<Map_UserRole> UserRoles { get; set; }


    }
}
