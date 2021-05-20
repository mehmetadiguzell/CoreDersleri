using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Controllers
{
    [AllowAnonymous]
    public class VitrinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryDetails(int id)
        {
            ViewBag.getId = id;
            return View();
        }
    }
}
