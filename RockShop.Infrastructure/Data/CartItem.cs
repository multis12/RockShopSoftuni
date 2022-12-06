using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Infrastructure.Data
{
    public class CartItem
    {
        [Required]
        public string AccountId { get; set; }

        [ForeignKey(nameof(AccountId))]
        public Account AccountUser { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
    }
}
