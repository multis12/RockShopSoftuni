using RockShop.Core.Contracts;

namespace RockShop.Core.Models.Product
{
    public class ProductIndexModel : IProductModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }
    }
}
