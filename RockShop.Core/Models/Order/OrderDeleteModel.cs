using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Core.Models.Order
{
    public class OrderDeleteModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
    }
}
