using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RockShop.Infrastructure.Data.Configuration;

namespace RockShop.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration()); 
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new TypeConfiguration());
            builder.ApplyConfiguration(new GuitarConfiguration());
            builder.ApplyConfiguration(new StaffConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Guitar> Guitars { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Type> Types { get; set; } = null!;

        public DbSet<Staff> Staffs { get; set; } = null!;
    }
}