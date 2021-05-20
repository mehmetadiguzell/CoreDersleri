using CoreIntro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreIntro.ViewComponents
{
    public class YeniKitaplar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var kitaplar = new List<Kitap>()
            {
                new Kitap{Id=5,KitapIsmi="1984",Yazar="George Owel"},
                new Kitap{Id=5,KitapIsmi="Empati",Yazar="Adam Fawer"},
                new Kitap{Id=5,KitapIsmi="Böylesi",Yazar="Serdat Tunç"}
            };

            return View(kitaplar);
        }
    }
}
