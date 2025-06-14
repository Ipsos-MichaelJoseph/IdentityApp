using IdentityApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApp.Controllers
{
    public class HomeController : Controller
    {
        private ProductDbContext _context;
        public HomeController(ProductDbContext context) => _context = context;

        public IActionResult Index() => View(_context.Products);

    }
}
