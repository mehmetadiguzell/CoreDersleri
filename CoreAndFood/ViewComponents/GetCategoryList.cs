using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.ViewComponents
{
    public class GetCategoryList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CategoryRepository categoryRepository = new();
            var categoryList = categoryRepository.GetAll();
            return View(categoryList);
        }
    }
}
