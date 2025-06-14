using IdentityApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApp.Controllers
{
    public class StoreController : Controller
    {
        private ProductDbContext _context;

        public StoreController(ProductDbContext context) => _context = context;

        public IActionResult Index() => View(_context.Products);
    }
}
