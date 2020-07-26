using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}