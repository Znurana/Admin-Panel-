using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_AdminPanel.Data;
using Test_AdminPanel.Models;

namespace Test_AdminPanel.Controllers
{
    [Authorize(Roles ="Admin")]
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
           
            var model = _context.Roles.ToList();
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


    }
}
