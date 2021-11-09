using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_AdminPanel.Models.VM
{
    public class UploadImageViewModel
    {
        [Required]

        public IFormFile SpeakerPicture { get; set; }
    }
}
