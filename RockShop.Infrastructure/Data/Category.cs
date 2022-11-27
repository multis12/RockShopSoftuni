using System.ComponentModel.DataAnnotations;

namespace RockShop.Infrastructure.Data
{
    public class Category
    {
        public Category()
        {
            Guitars = new List<Guitar>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; } = null!;

        public List<Guitar> Guitars { get; set; } = null!;
    }
}
