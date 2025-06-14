using Microsoft.EntityFrameworkCore;

namespace IdentityApp.Models
{
    public class ProductDbContext: DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Kayak", Price = 275, Category = "Watersports" },
                new Product() { Id = 2, Name = "Lifejacket", Price = 48.99m, Category = "Watersports" },
                new Product() { Id = 3, Name = "Ball", Price = 19.50m, Category = "Football"},
                new Product() { Id = 4, Name = "Corner Flags", Price = 34.99m, Category = "Football" },
                new Product() { Id = 5, Name = "Stadium", Price = 88.99m, Category = "Football" },
                new Product() { Id = 6, Name = "Baseball Cap", Price = 21.99m, Category = "Football" },
                new Product() { Id = 7, Name = "Scarf", Price = 12.99m, Category = "Football" },
                new Product() { Id = 8, Name = "Chair", Price = 46.99m, Category = "Chess" },
                new Product() { Id = 9, Name = "Human-sized Chess Board", Price = 75, Category = "Chess" }
            );
        
        }
    }
}
