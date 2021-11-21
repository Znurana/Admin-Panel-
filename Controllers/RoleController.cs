using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_AdminPanel.Data;
using Test_AdminPanel.Models;

namespace Test_AdminPanel.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {

        public readonly Context _context;

        public RoleController(Context context)
        {
            _context = context;

        }

        [HttpGet]
        public IActionResult Index()
        {

            var model = _context.UserRoles.ToList();
            return View(model);

        }

        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost]

        public IActionResult New(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return RedirectToAction("Index", "Role");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var rollar = _context.UserRoles.Find(id);
            //List<SelectListItem> degerler = (from d in _context.UserRoles.ToList()
            //                                 select new SelectListItem
            //                                 {
            //                                     Text = d.RoleName,
            //                                     Value = d.RoleID.ToString()


            //                                 }).ToList();
            
            //ViewBag.dgr = degerler;
            //return View(degerler);
            return View(rollar);

           

        }

        [HttpPost]
        public IActionResult Edit(int id, Map_UserRole model)
        {
          

            if (ModelState.IsValid)
            {
                var speaker = _context.UserRoles.Find(model.UserRoleID);

                speaker.UserRoleID = model.UserRoleID;
                speaker.UserID = model.UserID;
                speaker.RoleID = model.RoleID;
                speaker.RoleName = model.RoleName;
                speaker.IsActive = model.IsActive;
                speaker.CreateDate = model.CreateDate;



                _context.Update(speaker);
                _context.SaveChanges();
                return RedirectToAction("Index", "Role");

            }

            return View("Index");
        }



    }
}
