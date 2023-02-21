using Microsoft.AspNetCore.Mvc;

namespace P133Allup.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ProductModal()
        {
            return Ok();
        }
    }
}
