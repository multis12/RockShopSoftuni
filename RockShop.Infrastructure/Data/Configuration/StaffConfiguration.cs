using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RockShop.Infrastructure.Data.Configuration
{
    internal class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(new Staff()
            {
                Id = 1,
                UserId = "f2423455-638c-4558-b7eb-510312d02ef1",
                PhoneNumber = "+35988888"
            });
        }

    }
}
