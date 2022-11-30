using System.ComponentModel.DataAnnotations;

namespace RockShop.Core.Models.Product
{
    public class GuitarModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;
  
        [Required]
        [StringLength(2000)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string Neck { get; set; } = null!;

        [Required]
        [StringLength(60)]
        public string Body { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Bridge { get; set; } = null!;

        [Required]
        public int Frets { get; set; }

        [Required]
        [StringLength(60)]
        public string Adapters { get; set; } = null!;

        [Required]
        [Display(Name = "Price")]
        [Range(0.00, 1000000.00, ErrorMessage ="Price must be a positive number and less than {2} leva")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; } = null!;

        [Display(Name = "Type")]
        public int TypeId { get; set; }

        public IEnumerable<GuitarTypeModel> Types { get; set; } = new List<GuitarTypeModel>();

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<GuitarCategoryModel> Categories { get; set; } = new List<GuitarCategoryModel>();
    }
}
