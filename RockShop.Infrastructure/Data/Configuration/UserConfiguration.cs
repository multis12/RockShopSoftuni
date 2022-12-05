using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RockShop.Infrastructure.Data.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<Account> CreateUsers()
        {
            var users = new List<Account>();
            var hasher = new PasswordHasher<Account>();

            var user = new Account()
            {
                Id = "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                UserName = "user@mail.com",
                NormalizedUserName = "user@mail.com",
                Email = "user@mail.com",
                NormalizedEmail = "user@mail.com"
            };

            user.PasswordHash = hasher.HashPassword(user, "user123");

            users.Add(user);

            user = new Account()
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
