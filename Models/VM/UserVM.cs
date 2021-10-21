using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_AdminPanel.Models.VM
{
    public class UserVM
    {
       [Required(ErrorMessage ="Username daxil edin")]
        public string UserName { get; set; }
       [Required(ErrorMessage = "Password daxil edin")]
        public string UserPassword { get; set; }
    }
}
