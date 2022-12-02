namespace RockShop.Core.Models.Guitar
{
    public class GuitarQueryModel
    {
        public int TotalGuitarsCount { get; set; }

        public IEnumerable<GuitarServiceModel> Guitars { get; set; } = new List<GuitarServiceModel>();
    }
}
