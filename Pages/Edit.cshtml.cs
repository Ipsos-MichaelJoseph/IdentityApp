using IdentityApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityApp.Pages
{
    public class EditModel : PageModel
    {
        public ProductDbContext DbContext { get; set; }
        public Product Product { get; set; }

        public EditModel(ProductDbContext context) => DbContext = context;

        public void OnGet(long id)
        {
            Product = DbContext.Find<Product>(id) ?? new Product();
        }

        public IActionResult OnPost([Bind(Prefix ="Product")] Product product)
        {
            DbContext.Update(product);
            DbContext.SaveChanges();

            return RedirectToPage("Admin");
        }
    }
}
