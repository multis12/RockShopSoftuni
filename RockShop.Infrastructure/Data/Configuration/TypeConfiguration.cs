using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RockShop.Infrastructure.Data.Configuration
{
    internal class TypeConfiguration : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            builder.HasData(CreateTypes());
        }

        private List<Type> CreateTypes()
        {
            List<Type> types = new List<Type>()
            {
                new Type()
                {
                    Id = 1,
                    Name = "Acoustic"
                },

                new Type()
                {
                    Id = 2,
                    Name = "Electric"
                },

                new Type()
                {
                    Id = 3,
                    Name = "Electroacoustic"
                }
            };

            return types;
        }
    }
}
