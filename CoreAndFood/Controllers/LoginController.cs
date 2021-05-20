using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using CoreAndFood.Data.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace CoreAndFood.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Admin admin)
        {
            using (Context context = new())
            {
                var result = context.Admins.FirstOrDefault(c => c.UserName == admin.UserName && c.Password == admin.Password);
                if (result != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,admin.UserName)
                    };
                    var useridentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Food");
                }
                return View();
            }

        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
    }

}
