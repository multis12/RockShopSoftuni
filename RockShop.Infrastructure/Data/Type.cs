using System.ComponentModel.DataAnnotations;

namespace RockShop.Infrastructure.Data
{
    public class Type
    {
        public Type()
        {
            Products = new List<Product>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; } = null!;

        public List<Product> Products { get; set; } = null!;
    }
}
