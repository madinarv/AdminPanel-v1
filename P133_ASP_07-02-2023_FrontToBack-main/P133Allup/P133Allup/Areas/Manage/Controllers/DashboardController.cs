using Microsoft.AspNetCore.Mvc;

namespace P133Allup.Areas.Manage.Controllers
{  
    [Area("manage")]
    public class DashboardController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }
    }
}
