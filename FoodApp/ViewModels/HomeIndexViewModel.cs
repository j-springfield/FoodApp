using FoodApp.Models;
using System.Collections.Generic;

namespace FoodApp.ViewModels
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel()
        {
        }

        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }
    }
}
