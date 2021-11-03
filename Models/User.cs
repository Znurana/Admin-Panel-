using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test_AdminPanel.Models
{
    public class User
    {

        public int UserID { get; set; }

        [Display(Name = "Ad")]
        public string UserFirstName { get; set; }
        [Display(Name = "Soyad")]
        public string UserLastName { get; set; }
        [Display(Name = "Ata adı")]
        public string UserFatherName { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime BirthdayDate { get; set; }
        [Display(Name = "İstifadəçi adı")]
        public string UserName { get; set; }
        [Display(Name = "İstifadəçi parol")]
        public string UserPassword { get; set; }
        [Display(Name = "Stansiya Adı")]
        public int StationID { get; set; }
        public virtual Station station { get; set; }

        [Display(Name = "Kassa nömrəsi")]
        [ForeignKey("Kassa")]
        public int KassaID { get; set; }
        public Kassa kassa { get; set; }

        [Display(Name = "İstifadəçi yaranma tarixi")]

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime UserCreateDate { get; set; }

        [Display(Name = "İstifadəçi şəkili")]
        public string ProfilePicture { get; set; }
        public ICollection<Map_UserRole> UserRoles { get; set; }
        




    }
}

