using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.ViewComponents
{
    public class FoodListGetByCategory:ViewComponent
    {
        public IViewComponentResult Invoke(int id=0)
        {
            FoodRepository foodRepository = new();
            var foodFilter= foodRepository.FilterList(m=>m.CategoryId==id);
            return View(foodFilter);
        }
    }
}
