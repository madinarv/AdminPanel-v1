using Microsoft.AspNetCore.Mvc;

namespace P133Allup.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
