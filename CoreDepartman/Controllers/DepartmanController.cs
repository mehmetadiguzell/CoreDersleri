using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CoreDepartman.Controllers
{
    public class DepartmanController : Controller
    {
        public IActionResult Index()
        {
            using (Context context = new())
            {
                var model = context.Departmans.ToList();
                return View(model);
            }

        }

        public IActionResult YeniDepartman()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniDepartman(Departman departman)
        {

            using (Context context = new())
            {
                context.Departmans.Add(departman);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public IActionResult DepartmanSil(int id = 0)
        {
            using (Context context = new())
            {
                var result = context.Departmans.Find(id);
                context.Departmans.Remove(result);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public IActionResult DepartmanGetir(int id = 0)
        {
            using (Context context = new())
            {
                var result = context.Departmans.Find(id);
                return View("DepartmanGetir", result);
            }
        }
        [HttpPost]
        public IActionResult DepartmanGuncelle(Departman departman)
        {
            using (Context context = new())
            {
                context.Entry(departman).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");

            }
        }

        public IActionResult Detay(int id = 0)
        {
            using (Context context = new())
            {
                var result = context.Personels.Where(c => c.DepartmanId == id).ToList();
                return View(result);
            }
        }
    }
}
