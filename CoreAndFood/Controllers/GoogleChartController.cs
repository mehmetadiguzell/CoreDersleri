using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CoreAndFood.Controllers
{
    [AllowAnonymous]
    public class GoogleChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VisualizeProductResult()
        {

            return Json(ProductList());
        }
        public List<Chart> ProductList()
        {
            List<Chart> myList = new();

            using (var context = new Context())
            {
                myList = context.Foods.Select(
                    x => new Chart()
                    {
                        productname = x.Name,
                        stock = x.Stock
                    }).ToList();             
            }
            return myList;
        }
        public IActionResult Statistics()
        {
            Context context = new();

            var q1 = context.Foods.Count();
            ViewBag.TotalFood = q1;

            var q2 = context.Categories.Count();
            ViewBag.TotalCategory = q2;

            var q3 = context.Foods.Where(c=>c.CategoryId==1).Count();
            ViewBag.TotalVegetables = q3;

            var q4 = context.Foods.Where(c => c.CategoryId == 2).Count();
            ViewBag.TotalFruit = q4;

            var q5 = context.Foods.Sum(m => m.Stock);
            ViewBag.TotalStock = q5;

            var q6 = context.Foods.Where(
                c => c.CategoryId == context.Categories.Where(
                    y => y.CategoryName == "Legumes")
                .Select(z => z.Id).FirstOrDefault()).Count();
            ViewBag.TotalLegumes = q6;

            var q7 = context.Foods.OrderByDescending(c => c.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.d7 = q7;

            var q8 = context.Foods.OrderBy(c => c.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.d8 = q8;

            var q9 = context.Foods.Average(c => c.Price).ToString("0.00");
            ViewBag.d9 = q9;


            return View();
        }
    }
}

