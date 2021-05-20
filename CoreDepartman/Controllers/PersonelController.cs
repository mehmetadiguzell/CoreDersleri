using CoreDepartman.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
namespace CoreDepartman.Controllers
{
    public class PersonelController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            using (Context context = new())
            {
                var model = context.Personels.Include(d => d.Departman).ToList();
                //var model = context.Personels.ToList();
                return View(model);
            }
        }

        public IActionResult YeniPersonel()
        {
            using (Context context = new())
            {

                List<SelectListItem> departmanList = (from i in context.Departmans.ToList()
                                                      select new SelectListItem()
                                                      {
                                                          Text = i.DepartmanAd,
                                                          Value = i.Id.ToString()
                                                      }).ToList();
                ViewBag.Departmanlar = departmanList;
                return View();
            }
        }


        [HttpPost]
        public IActionResult YeniPersonel(Personel personel)
        {
            using (Context context = new())
            {
                context.Personels.Add(personel);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public IActionResult PersonelSil(int id = 0)
        {
            using (Context context = new())
            {
                var result = context.Personels.Find(id);
                context.Personels.Remove(result);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public IActionResult PersonelGuncelle(int id = 0)
        {
            using (Context context = new())
            {
                List<SelectListItem> departmanList = (from i in context.Departmans.ToList()
                                                      select new SelectListItem()
                                                      {
                                                          Text = i.DepartmanAd,
                                                          Value = i.Id.ToString()
                                                      }).ToList();
                ViewBag.Departmanlar = departmanList;
                var result = context.Personels.Find(id);
                return View("PersonelGuncelle", result);
            }
        }
        [HttpPost]
        public IActionResult PersonelGuncelle(Personel personel)
        {
            using (Context context = new())
            {
                context.Entry(personel).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");

            }
        }
    }
}

