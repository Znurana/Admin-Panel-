using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Test_AdminPanel.Data;
using Test_AdminPanel.Models;

namespace Test_AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        public readonly Context _context;
        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index(User user)
        {
            //database-dan olan melumatlari list edir
            var model = _context.Users.ToList();
            return View(model);
           
        }

        [HttpGet]
        public async Task<IActionResult> Index(string Empsearch)
        {
            ViewData["GetEmployeedetails"] = Empsearch;
            var empquery=from x in _context.Users select x;
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x => x.UserName.Contains(Empsearch) || x.UserFirstName.Contains(Empsearch) || x.UserLastName.Contains(Empsearch)  || x.UserFatherName.Contains(Empsearch));
            }
            return View(await empquery.AsNoTracking().ToListAsync());

        }

      




        [HttpGet]
        public IActionResult New()
        {

            return View("Edit", new User());
        }

        [ValidateAntiForgeryToken]
        public IActionResult Save(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit");
            }

            //id==0 Add edir
            if (user.UserID == 0)
            {
                _context.Users.Add(user);

            }
            else
            {
                //var guncellenecekEmployee = _context.Users.Find(user.UserID);
                //if (guncellenecekEmployee == null)
                //{
                //    return Content("Not Found");
                //}

                ////guncellenecekEmployee.UserID = user.UserID;
                //guncellenecekEmployee.UserFirstName = user.UserFirstName;
                //guncellenecekEmployee.UserLastName = user.UserLastName;
                //guncellenecekEmployee.UserFatherName = user.UserFatherName;
                //guncellenecekEmployee.UserName = user.UserName;
                //guncellenecekEmployee.UserPassword = user.UserPassword;
                //guncellenecekEmployee.StationID = user.StationID;
                //guncellenecekEmployee.KassaID = user.KassaID;
                //guncellenecekEmployee.UserCreateDate = user.UserCreateDate;



            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _context.Users.Find(id);
            if (model == null)
                return Content("Not Found !");

            return View("Edit", model);
        }



        public IActionResult Delete(int id)
        {
            var deleteUser = _context.Users.Find(id);
            if (deleteUser == null)
                return Content("Bu User tapilmadi");
            _context.Users.Remove(deleteUser);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}
