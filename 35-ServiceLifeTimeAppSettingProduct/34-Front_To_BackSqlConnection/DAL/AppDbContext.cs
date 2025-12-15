using Microsoft.EntityFrameworkCore;
using task777.Models;

namespace task777.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ServiceFeature> ServiceFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceFeature>().HasData(
                new ServiceFeature { Id = 1, Title = "Free Shipping", Description = "Capped at $319 per order", IconClass = "fa-truck", Order = 1 },
                new ServiceFeature { Id = 2, Title = "Safe Payment", Description = "With our payment gateway", IconClass = "fa-credit-card", Order = 2 },
                new ServiceFeature { Id = 3, Title = "Best Services", Description = "Friendly & Supper Services", IconClass = "fa-hands-helping", Order = 3 }
                );
        }
    }
}