using Microsoft.AspNetCore.Mvc;

namespace VBV3Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
