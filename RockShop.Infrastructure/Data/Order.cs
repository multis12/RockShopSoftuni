using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Infrastructure.Data
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AccountId { get; set; } = null!;

        [ForeignKey(nameof(AccountId))]
        public AppUser Acc { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(30)]
        public string SecondName { get; set; } = null!;

        [Required]
        [StringLength(150)]
        public string Adress { get; set; } = null!;

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        [StringLength(60)]
        public string Email { get; set; } = null!;
    }
}
