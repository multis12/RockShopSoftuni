using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RockShop.Infrastructure.Data.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<AppUser> CreateUsers()
        {
            var users = new List<AppUser>();
            var hasher = new PasswordHasher<AppUser>();

            var user = new AppUser()
            {
                Id = "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                UserName = "user@mail.com",
                NormalizedUserName = "user@mail.com",
                Email = "user@mail.com",
                NormalizedEmail = "user@mail.com"
            };

            user.PasswordHash = hasher.HashPassword(user, "user123");

            users.Add(user);

            user = new AppUser()
            {
                Id = "f2423455-638c-4558-b7eb-510312d02ef1",
                UserName = "admin@mail.com",
                NormalizedUserName = "admin@mail.com",
                Email = "admin@mail.com",
                NormalizedEmail = "admin@mail.com"
            };
            user.PasswordHash = hasher.HashPassword(user, "admin123");

            users.Add(user);

            return users;
        }
    }
}
