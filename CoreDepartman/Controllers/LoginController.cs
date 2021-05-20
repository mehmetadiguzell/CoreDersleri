using CoreDepartman.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDepartman.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GirisYap(Admin admin)
        {
            using (Context context = new())
            {
                var result = context.Admins.FirstOrDefault(c => c.KullaniciAdi == admin.KullaniciAdi && c.Sifre == admin.Sifre);
                if (result != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,admin.KullaniciAdi)
                    };
                    var useridentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Departman");
                }
            }

            return View();
        }
    }
}
