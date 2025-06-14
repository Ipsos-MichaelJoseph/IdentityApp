using Microsoft.AspNetCore.Mvc;

using IdentityApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace IdentityApp.Pages
{
    public class LandingModel : PageModel
    {
        public ProductDbContext DbContext { get; set; }
        public LandingModel(ProductDbContext context) => DbContext = context;

    }
}
