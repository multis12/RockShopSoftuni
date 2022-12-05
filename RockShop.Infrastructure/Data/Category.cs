using System.ComponentModel.DataAnnotations;

namespace RockShop.Infrastructure.Data
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; } = null!;

        public List<Product> Products { get; set; } = null!;
    }
}
