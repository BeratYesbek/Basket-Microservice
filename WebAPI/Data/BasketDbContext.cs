using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class BasketDbContext : DbContext
    {
        public BasketDbContext(DbContextOptions<BasketDbContext> contextOptions) : base(contextOptions)
        {
            
        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<ProductImage>? ProductImages { get; set; }
        public DbSet<ShoppingCart>? ShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasOne(p => p.Category).WithMany(c => c.Products);
            modelBuilder.Entity<ProductImage>().HasOne(p => p.Product).WithMany(c => c.ProductImages);
            modelBuilder.Entity<ShoppingCart>().HasOne(p => p.Product).WithMany(t => t.ShoppingCarts);
        }
    }
}
