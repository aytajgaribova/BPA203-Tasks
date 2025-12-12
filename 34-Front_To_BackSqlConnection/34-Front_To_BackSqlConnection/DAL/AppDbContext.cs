using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace task777.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public ISet<Slider> Sliders { get; set; }
        public Dbset<ServiceFeature> ServiceFeature { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ServiceFeature>().HasData(
                new ServiceFeature { Id = 1, Title = "Free Shipping", Description = "Capped at $319 per order", IconClass = "fa-truck", Order = 1 },
                new ServiceFeature { Id = 2, Title = "Safe Payment", Description = "With our payment gateway", IconClass = "fa-credit-card", Order = 2 },
                new ServiceFeature { Id = 3, Title = "Best Services", Description = "Friendly & Supper Services", IconClass = "fa-hands-helping", Order = 3 }

    }
    }
}