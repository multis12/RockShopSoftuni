using RockShop.Infrastructure.Data.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RockShop.Infrastructure.Data;
using Type = RockShop.Infrastructure.Data.Type;

namespace RockShop.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CartItem>().HasKey(x => new { x.AccountId, x.ProductId });
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new StaffConfiguration());
            builder.ApplyConfiguration(new TypeConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Type> Types { get; set; } = null!;

        public DbSet<Staff> Staff { get; set; } = null!;

    }
}