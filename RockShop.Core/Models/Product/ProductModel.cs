using RockShop.Core.Contracts;
using System.ComponentModel.DataAnnotations;

namespace RockShop.Core.Models.Product
{
    public class ProductModel : IProductModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;
  
        [Required]
        [StringLength(2000)]
        public string Description { get; set; } = null!;

        [StringLength(100)]
        public string? Neck { get; set; }

        [StringLength(60)]
        public string? Body { get; set; }

        [StringLength(50)]
        public string? Bridge { get; set; }

        [StringLength(50)]
        public string? Tune { get; set; }

        public int? Holes { get; set; }

        public int? Frets { get; set; }

        [StringLength(60)]
        public string? Adapters { get; set; }

        [Required]
        [Display(Name = "In Stock")]
        public bool InStock { get; set; }

        [Required]
        [Display(Name = "Price")]
        [Range(0.00, 1000000.00, ErrorMessage ="Price must be a positive number and less than {2} leva")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; } = null!;

        [Display(Name = "Type")]
        public int? TypeId { get; set; }

        public IEnumerable<ProductTypeModel> Types { get; set; } = new List<ProductTypeModel>();

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<ProductCategoryModel> Categories { get; set; } = new List<ProductCategoryModel>();
    }
}
