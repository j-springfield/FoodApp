using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodApp.Controllers
{
    //about

    [Route("[controller]/[action]")]
    public class AboutController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        public IActionResult Phone()
        {
            return Content("1+555+555+5555");
        }

        [Route("[action]")]
        public IActionResult Address()
        {
            return Content("USA");
        }
    }
}
