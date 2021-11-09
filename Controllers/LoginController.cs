using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Test_AdminPanel.Data;
using Test_AdminPanel.Models.VM;

namespace Test_AdminPanel.Controllers
{
    [AllowAnonymous]

    public class LoginController : Controller
    {

       
        public readonly Context _context;
        private readonly ILogger<LoginController> _logger;
        public LoginController(Context context, ILogger<LoginController> logger)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index( UserVM data)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserName == data.UserName && x.UserPassword == data.UserPassword);
            ClaimsIdentity identity = null;
            bool isAuthenticate = false;

            if (user != null)
            {
                var userRoles = _context.UserRoles.Where(ur => ur.UserID == user.UserID);
                var roles = _context.Roles.Where(ro => userRoles.Any(ur => ur.RoleID == ro.RoleID));
                identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                foreach (var item in roles)
                {
                    identity.AddClaim(new Claim(ClaimTypes.Role, item.RoleName));
                }
                identity.AddClaim(new Claim(ClaimTypes.Name, data.UserName));
                isAuthenticate = true;
            }
            if (isAuthenticate)
            {
                var principal = new ClaimsPrincipal(identity);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Index", "Main");
            }
            else
            {
                ViewBag.Mesaj = "İstifadəçi adı və ya şifrə yanlışdır";
                return View();
            }
            

        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Response.Cookies.Delete(".AspNetCore.Cookies");
            return RedirectToAction("Index", "Login");
        }

    }
}
