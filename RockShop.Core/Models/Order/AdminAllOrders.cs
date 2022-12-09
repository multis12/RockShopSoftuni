using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Core.Models.Order
{
    public class AdminAllOrders
    {
        public IEnumerable<OrderServiceModel> AllOrders { get; set; } = Enumerable.Empty<OrderServiceModel>();
    }
}
