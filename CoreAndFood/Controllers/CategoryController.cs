using CoreAndFood.Data.Models;
using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace CoreAndFood.Controllers
{

    public class CategoryController : Controller
    {
        CategoryRepository repository = new();

        public IActionResult Index()
        {
            var result = repository.GetAll();

            return View(result);
        }

        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            repository.Add(category);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryGet(int id = 0)
        {
            var result = repository.GetById(id);
            return View(result);
        }

        public IActionResult CategoryUpdate(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryGet");
            }
            repository.Update(category);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryDelete(int id = 0)
        {
            var result = repository.GetById(id);
            result.Status = false;
            repository.Update(result);
            return RedirectToAction("Index");
        }
    }
}
