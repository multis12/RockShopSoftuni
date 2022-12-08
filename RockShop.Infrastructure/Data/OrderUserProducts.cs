using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RockShop.Infrastructure.Data
{
    public class OrderUserProducts
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AccountId { get; set; }

        [ForeignKey(nameof(AccountId))]
        public AppUser AccountUser { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
    }
}
