using IdentityApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApp.Controllers
{
    public class AdminController : Controller
    {
        private ProductDbContext _context;

        public AdminController(ProductDbContext context) => _context = context;
        public IActionResult Index() => View(_context.Products);

        [HttpGet]
        public IActionResult Create() => View("Edit", new Product());

        [HttpGet]
        public IActionResult Edit(long id)
        {
            Product product = _context.Find<Product>(id);

            if(product != null)
            {
                return View("Edit", product);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Save(Product product)
        {
            //Product p = _context.Find<Product>(product.Id);
            _context.Products.Update(product);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(long id)
        {
            Product product = _context.Find<Product>(id);

            if(product != null) 
            {
                _context.Remove(product);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
