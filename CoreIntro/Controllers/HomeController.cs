using CoreIntro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace CoreIntro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Kitap()
        {
            var List = new List<Kitap>()
            {
                new Kitap(){Id=1,KitapIsmi="Olasılıksız",Yazar="Adam Fawer"},
                new Kitap(){Id=2,KitapIsmi="OD",Yazar="İskender Pala"},
                new Kitap(){Id=3,KitapIsmi="OZ",Yazar="Adam Fawer"},
            };
            return View(List);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
