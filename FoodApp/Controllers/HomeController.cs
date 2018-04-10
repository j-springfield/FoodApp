using FoodApp.Models;
using FoodApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodApp.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = _restaurantData.GetAll();

            //return new ObjectResult(model);
            return View(model);
        }
    }
}
