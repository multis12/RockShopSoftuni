namespace RockShop.Core.Models.Product
{
    public class ProductQueryModel
    {
        public int TotalGuitarsCount { get; set; }

        public IEnumerable<ProductServiceModel> Guitars { get; set; } = new List<ProductServiceModel>();
    }
}
