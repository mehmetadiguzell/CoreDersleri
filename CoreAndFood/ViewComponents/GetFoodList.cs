using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.ViewComponents
{
    public class GetFoodList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FoodRepository foodRepository = new();
            var foodList = foodRepository.GetAll();
            return View(foodList);
        }
    }
}
