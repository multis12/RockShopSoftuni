using System.ComponentModel.DataAnnotations;

namespace RockShop.Infrastructure.Data
{
    public class Type
    {
        public Type()
        {
            Guitars = new List<Guitar>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; } = null!;

        public List<Guitar> Guitars { get; set; } = null!;
    }
}
