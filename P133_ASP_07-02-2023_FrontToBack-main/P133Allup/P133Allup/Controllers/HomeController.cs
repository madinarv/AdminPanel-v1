using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P133Allup.DataAccessLayer;
using P133Allup.ViewModels.HomeViewModels;

namespace P133Allup.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context= context;
        }


        public async Task <IActionResult> Index()
        {
            HomeVm vm = new HomeVm
            {
                Sliders = await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync(),
                Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync(),
                Features = await _context.Products.Where(p => p.IsDeleted == false && p.IsFeatured).ToListAsync(),
                BestSeller = await _context.Products.Where(p => p.IsDeleted == false && p.IsBestSeller).ToListAsync(),
                NewArrival = await _context.Products.Where(p => p.IsDeleted == false && p.IsNewArrival).ToListAsync()
            };

            return View(vm);
        }
    }
}
