using RockShop.Core.Models.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RockShop.Core.Models.Order
{
    public class OrderServiceModel
    {
        public int Id { get; set; }

        public string AccountId { get; set; }

        public string FirstName { get; set; } = null!;

        public string SecondName { get; set; } = null!;

        public string Address { get; set; } = null!;

        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } = null!;

        public List<OrderProductServiceModel> OrderProducts { get; set; } = new List<OrderProductServiceModel>();
    }
}
