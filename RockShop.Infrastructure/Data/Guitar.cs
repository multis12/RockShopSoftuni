using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockShop.Infrastructure.Data
{
    public class Guitar
    {
        [Key]
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
        public int TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public Type Type { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        [Column(TypeName = "money")]
        [Precision(18,2)]
        public decimal Price { get; set; }

        [Required]
        public bool InStock { get; set; }

        [Required]
        [StringLength(200)]
        public string ImageUrl { get; set; } = null!;

        
    }
}
