using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_AdminPanel.Data;
using Test_AdminPanel.Helper;
using Test_AdminPanel.Models;
using Test_AdminPanel.Models.VM;


namespace Test_AdminPanel.Controllers
{
    [Authorize]
    public class MainController : Controller
    {

        public readonly Context _context;
        public MainController(Context context)
        {
            _context = context;
        }
    
        
        public async Task<IActionResult> Index(string Empsearch)
        {
            var user = await _context.Users.Include(m => m.station).ToListAsync();
            if (Empsearch != null)
            {
              
                ViewData["GetEmployeedetails"] = Empsearch;
                var empquery = from x in _context.Users.Include(m=>m.station) select x;
                if (!String.IsNullOrEmpty(Empsearch))
                {
                    empquery = empquery.Where(x => x.UserName.Contains(Empsearch) || x.UserFirstName.Contains(Empsearch) || x.UserLastName.Contains(Empsearch) || x.UserFatherName.Contains(Empsearch));
                }
                return View(await empquery.AsNoTracking().ToListAsync());
            }
            return View(user);

        }
     



        public IActionResult AccessDenied(UserVM userVM)
        {
            return Json("access denied");
        }


    }

}

