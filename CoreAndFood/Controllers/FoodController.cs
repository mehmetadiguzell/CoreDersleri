using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository repository = new();

        public IActionResult Index(int page=1)
        {          
            var result = repository.Include("Category").ToPagedList(page, 2);
            return View(result);
        }

        public IActionResult FoodAdd()
        {
            using (Context context = new())
            {
                List<SelectListItem> result = (from x in context.Categories.ToList()
                                               select new SelectListItem()
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.Id.ToString()
                                               }).ToList();
                ViewBag.categoryList = result;
                return View();
            }

        }
        [HttpPost]
        public IActionResult FoodAdd(Food food)
        {
            repository.Add(food);
            return RedirectToAction("Index");
        }

        public IActionResult FoodDelete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult FoodGet(int id)
        {
            using (Context context = new())
            {
                List<SelectListItem> result = (from x in context.Categories.ToList()
                                               select new SelectListItem()
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.Id.ToString()
                                               }).ToList();
                ViewBag.categoryList = result;
                var food = repository.GetById(id);
                return View(food);
            }
        }

        public IActionResult FoodUpdate(Food food)
        {
            repository.Update(food);
            return RedirectToAction("Index");
        }
    }
}
