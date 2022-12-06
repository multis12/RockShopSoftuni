using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RockShop.Infrastructure.Data.Configuration;

namespace RockShop.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<Account>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CartItem>().HasKey(x => new { x.AccountId, x.ProductId });
            builder.ApplyConfiguration(new UserConfiguration()); 
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new TypeConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new StaffConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Type> Types { get; set; } = null!;

        public DbSet<Staff> Staffs { get; set; } = null!;
    }
}