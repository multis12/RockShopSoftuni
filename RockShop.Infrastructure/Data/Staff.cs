using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockShop.Infrastructure.Data
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AccountId { get; set; } = null!;

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; } = null!;

        
        public IEnumerable<Product>? Products { get; set; }

        [ForeignKey(nameof(AccountId))]
        public Account User { get; set; } = null!;
    }
}
