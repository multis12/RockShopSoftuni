using System.ComponentModel.DataAnnotations;

namespace RockShop.Core.Models.Product
{
    public class ProductServiceModel
    {
        public int Id { get; init; }

        public string Name { get; init; } = null!;

        [Display(Name = "Image Url")]
        public string ImageUrl { get; init; } = null!;

        [Display(Name = "Price")]
        public decimal Price { get; init; }

        [Display(Name = "In Stock")]
        public bool InStock { get; set; }
    }
}
