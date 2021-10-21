using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Test_AdminPanel.Data;
using Test_AdminPanel.Models.VM;

namespace Test_AdminPanel.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        
        public readonly Context _context;
        
        public LoginController(Context context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(UserVM user)
        {
           
            var kullaniciInDb = _context.Users.FirstOrDefault(x => x.UserName == user.UserName && x.UserPassword == user.UserPassword);

            if (kullaniciInDb != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.UserName)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);

                await HttpContext.SignInAsync(principal);

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
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index","Login");
        }
    }
}
