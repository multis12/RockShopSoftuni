using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RockShop.Infrastructure.Data.Configuration
{
    internal class GuitarConfiguration : IEntityTypeConfiguration<Guitar>
    {
        public void Configure(EntityTypeBuilder<Guitar> builder)
        {
            builder.HasData(CreateGuitars());
        }

        private List<Guitar> CreateGuitars()
        {
            List<Guitar> guitars = new List<Guitar>()
            {
                new Guitar()
                {
                    Id = 1,
                    Name = "Ibanez GRG170DX BKN",
                    Description = "Amazing guitar for beginner and intermediate players!",
                    Neck = "Maple",
                    Body= "Poplar",
                    Bridge = "T102 Tremolo",
                    Frets = 24,
                    Adapters = "Humbucker",
                    TypeId = 2,
                    CategoryId = 1,
                    Price = 528.00M,
                    InStock = true,
                    ImageUrl = "https://rockshock.eu/uploads/2021/10/01/1633091545_8612_i.webp"
                },

                    new Guitar()
                {
                    Id = 2,
                    Name = "Ibanez RGT6EX-IPT",
                    Description = "Amazing guitar for advanced players!",
                    Neck = "Wizard II Maple/Walnut neck-thru",
                    Body = "Mahogany wing",
                    Bridge = "T102 Tremolo",
                    Frets = 24,
                    Adapters = "EMG® 85",
                    TypeId = 2,
                    CategoryId = 1,
                    InStock = true,
                    Price = 1721.00M,
                    ImageUrl = "https://rockshock.eu/uploads/2021/10/01/1633091523_6553_i.webp"
                },

                new Guitar()
                {
                    Id = 3,
                    Name = "Ibanez AAD100 OPN",
                    Description = "Clear sound and amazing feeling!",
                    Neck = "Low Oval Grip with Rounded Fretboard EdgeThermo Aged™ Nyatoh neck",
                    Body = "Grand Dreadnought body",
                    Bridge = "Ovangkol Scalloped bridge",
                    Frets = 20,
                    Adapters = "None",
                    TypeId = 1,
                    InStock = true,
                    CategoryId = 1,
                    Price = 548.00M,
                    ImageUrl = "https://rockshock.eu/uploads/2022/04/12/1649751909_0387_i.webp"
                }

            };
            return guitars;
        }
    }
}
