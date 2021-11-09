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
using Test_AdminPanel.Models.VM;
using X.PagedList;

namespace Test_AdminPanel.Controllers
{[Authorize]
    public class MainController : Controller
    {

        public readonly Context _context;
        public MainController(Context context)
        {
            _context = context;
        }

        //public IActionResult Index()
        //{

        //    var model = _context.Users.Include(m=>m.station).ToList();
        //    return View(model);

        //}
        //public async Task<IActionResult> Index(int pageNumber = 1)
        //{

        //    return View(await PaginatedList<User>.CreateAsync(_context.Users.Include(m => m.station), pageNumber, 3));

        //}


       
        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            //var user = await _context.Users.Include(m => m.station).ToListAsync();
            return View(await PaginatedList<User>.CreateAsync(_context.Users.Include(m => m.station), pageNumber, 5));

            //return View(user);
        }

        
        public IActionResult IndexS()
        {

            var model = _context.Users.Include(m => m.station).ToList();
            return View(model);


        }

        //SEARCH
        [HttpGet]
        public async Task<IActionResult> IndexS(string Empsearch)
        {


            ViewData["GetEmployeedetails"] = Empsearch;
            var empquery = from x in _context.Users select x;
            if (!String.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x => x.UserName.Contains(Empsearch) || x.UserFirstName.Contains(Empsearch) || x.UserLastName.Contains(Empsearch));
            }
            return View(await empquery.AsNoTracking().ToListAsync());

        }


        public IActionResult AccessDenied(UserVM userVM)
        {
            return Json("access denied");
        }


    }

}

