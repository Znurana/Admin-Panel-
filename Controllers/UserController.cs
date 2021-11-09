using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Test_AdminPanel.Data;
using Test_AdminPanel.Models;
using Test_AdminPanel.Models.VM;

namespace Test_AdminPanel.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public readonly Context _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UserController(Context context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _webHostEnvironment = hostEnvironment;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Index()
        {
            List<SelectListItem> degerler = (from x in _context.stations.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.StationName,
                                                 Value = x.StationID.ToString()


                                             }).ToList();

            ViewBag.dgr = degerler;

            return View();

        }

        // Add User
        [Authorize(Roles = "Admin")]
        [HttpPost]

        public async Task<IActionResult> Index(UserFileVM model)
        {
            List<SelectListItem> degerler = (from x in _context.stations.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.StationName,
                                                 Value = x.StationID.ToString()


                                             }).ToList();

            ViewBag.dgr = degerler;
            var per = _context.stations.Where(x => x.StationID == model.station.StationID).FirstOrDefault();
            model.station = per;



            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);
                User users = new User
                {

                    UserFirstName = model.UserFirstName,
                    UserLastName = model.UserLastName,
                    UserFatherName = model.UserFatherName,
                    BirthdayDate = model.BirthdayDate,
                    UserName = model.UserName,
                    UserPassword = model.UserPassword,
                    StationID = model.station.StationID,
                    KassaID = model.KassaID,
                    UserCreateDate = model.UserCreateDate,
                    ProfilePicture = uniqueFileName,

                };
                _context.Add(users);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Main");

            }

            return View(model);
        }


        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            List<SelectListItem> degerler = (from d in _context.stations.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = d.StationName,
                                                 Value = d.StationID.ToString()


                                             }).ToList();

            ViewBag.dgr = degerler;

            if (id == null)
            {
                return NotFound();
            }

            var speaker = await _context.Users.FindAsync(id);
            var speakerViewModel = new UserFileVM()
            {
                UserID = speaker.UserID,
                UserFirstName = speaker.UserFirstName,
                UserLastName = speaker.UserLastName,
                UserFatherName = speaker.UserFatherName,
                BirthdayDate = speaker.BirthdayDate,
                UserName = speaker.UserName,
                UserPassword = speaker.UserPassword,
                StationID = speaker.station.StationID,
                KassaID = speaker.KassaID,
                ExistingImage = speaker.ProfilePicture

            };

            if (speaker == null)
            {
                return NotFound();
            }
            return View(speakerViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UserFileVM model)
        {
            List<SelectListItem> degerler = (from d in _context.stations.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = d.StationName,
                                                 Value = d.StationID.ToString()


                                             }).ToList();

            ViewBag.dgr = degerler;
            if (ModelState.IsValid)
            {
                var speaker = await _context.Users.FindAsync(model.Id);

                speaker.UserFirstName = model.UserFirstName;
                speaker.UserLastName = model.UserLastName;
                speaker.UserFatherName = model.UserFatherName;
                speaker.BirthdayDate = model.BirthdayDate;
                speaker.UserName = model.UserName;
                speaker.UserPassword = model.UserPassword;
                speaker.StationID = model.StationID;
                speaker.KassaID = model.KassaID;
                
                if (model.SpeakerPicture != null)
                {
                   
                    if (model.ExistingImage != null)
                    {
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, FileLocation.FileUploadFolder, model.ExistingImage);
                        System.IO.File.Delete(filePath);
                    }
                    speaker.ProfilePicture = ProcessUploadedFile(model);
                }
                _context.Update(speaker);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Main");

            }
        
            return View();
        }

        private bool SpeakerExists(int id)
        {
            return _context.Users.Any(e => e.UserID == id);
        }
        private string ProcessUploadedFile(UserFileVM model)
        {
            string uniqueFileName = null;

            if (model.SpeakerPicture != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.SpeakerPicture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.SpeakerPicture.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }



        [Authorize(Roles = "Admin,Delete")]

        //Delete - Safura,Admin
        [HttpGet]
        public IActionResult UserDelete(int id)
        {
            var deleteUser = _context.Users.Find(id);
            if (deleteUser == null)
                return Content("Bu User tapilmadi");
            _context.Users.Remove(deleteUser);
            _context.SaveChanges();

            return RedirectToAction("Index", "Main");
        }


    }
}
