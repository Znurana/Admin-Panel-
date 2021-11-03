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
        private readonly IWebHostEnvironment webHostEnvironment;
        public UserController(Context context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
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


        [Authorize(Roles = "Admin")]
        [HttpPost]

        public async Task<IActionResult> Index(UserFileVM user)
        {
            var per = _context.stations.Where(x => x.StationID == user.station.StationID).FirstOrDefault();
            user.station = per;
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(user);

                User users = new User
                {
                    UserID = user.UserID,
                    UserFirstName = user.UserFirstName,
                    UserLastName = user.UserLastName,
                    UserFatherName = user.UserFatherName,
                    BirthdayDate=user.BirthdayDate,
                    UserName = user.UserName,
                    UserPassword = user.UserPassword,
                    StationID = user.station.StationID,
                    KassaID = user.KassaID,
                    UserCreateDate = user.UserCreateDate,
                    ProfilePicture = uniqueFileName,
                };
                _context.Add(users);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Main");
            }
            return View();
        }


        private string UploadedFile(UserFileVM user)
        {
            string uniqueFileName = null;

            if (user.ProfileImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + user.ProfileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    user.ProfileImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }



        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _context.Users.Find(id);
            
            if (model == null)
                return Content("Not Found !");

            List<SelectListItem> degerler = (from d in _context.stations.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = d.StationName,
                                                 Value = d.StationID.ToString()


                                             }).ToList();

            ViewBag.dgr = degerler;

            return View("Edit", model);
        }
        [Authorize(Roles = "Admin")]
        //Edit
        public IActionResult Save(User user)
        {

            if (!ModelState.IsValid)
            {
                return View("Edit");
            }

            var guncellenecekEmployee = _context.Users.Find(user.UserID);
            if (guncellenecekEmployee == null)
            {
                return Content("Not Found");
            }

            guncellenecekEmployee.UserFirstName = user.UserFirstName;
            guncellenecekEmployee.UserLastName = user.UserLastName;
            guncellenecekEmployee.UserFatherName = user.UserFatherName;
            guncellenecekEmployee.BirthdayDate = user.BirthdayDate;
            guncellenecekEmployee.UserName = user.UserName;
            guncellenecekEmployee.UserPassword = user.UserPassword;
            guncellenecekEmployee.StationID = user.StationID;
            guncellenecekEmployee.KassaID = user.KassaID;
            guncellenecekEmployee.UserCreateDate = user.UserCreateDate;
            guncellenecekEmployee.ProfilePicture = user.ProfilePicture;


            _context.SaveChanges();

            return RedirectToAction("Index", "Main");
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
