using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test_AdminPanel.Models.VM
{
    public class UserFileVM
    {
        public int UserID { get; set; }

        public string UserFirstName { get; set; }


        public string UserLastName { get; set; }


        public string UserFatherName { get; set; }


        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public int StationID { get; set; }
        public virtual Station station { get; set; }


        [ForeignKey("Kassa")]
        public int KassaID { get; set; }
        public Kassa kassa { get; set; }

        
        public DateTime UserCreateDate { get; set; } = DateTime.Now;


        [Display(Name = "Profile Picture")]
        public IFormFile ProfileImage { get; set; }


    }
}
