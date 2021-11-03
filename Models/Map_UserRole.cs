using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_AdminPanel.Models
{
    public class Map_UserRole
    {
        [Key]
        public int UserRoleID { get; set; }


        public int UserID { get; set; }
        public virtual User User { get; set; }


        public int RoleID { get; set; }
        public virtual Role Role { get; set; }

        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }



    }
}
