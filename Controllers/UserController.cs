using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_AdminPanel.Data;
using Test_AdminPanel.Models;

namespace Test_AdminPanel.Controllers
{
//    [Authorize(Roles =]
    public class UserController : Controller
    {
        public readonly Context _context;
        public UserController(Context context)
        {
            _context = context;
        }

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
        [HttpPost]
        public IActionResult Index(User user)
        {
            var per = _context.stations.Where(x => x.StationID == user.station.StationID).FirstOrDefault();
            user.station = per;
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Index", "Main");
        }
        


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

           
            //guncellenecekEmployee.UserID = user.UserID;
            guncellenecekEmployee.UserFirstName = user.UserFirstName;
            guncellenecekEmployee.UserLastName = user.UserLastName;
            guncellenecekEmployee.UserFatherName = user.UserFatherName;
            guncellenecekEmployee.UserName = user.UserName;
            guncellenecekEmployee.UserPassword = user.UserPassword;
            guncellenecekEmployee.StationID = user.StationID;
            guncellenecekEmployee.KassaID = user.KassaID;
            guncellenecekEmployee.UserCreateDate = user.UserCreateDate;


            _context.SaveChanges();
            
           return RedirectToAction("Index", "Main");
        }


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
