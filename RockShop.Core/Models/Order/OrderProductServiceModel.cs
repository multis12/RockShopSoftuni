using RockShop.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RockShop.Core.Models.Order
{
    public class OrderProductServiceModel
    {
        public string AccountId { get; set; }

        public int ProductId { get; set; }
    }
}
