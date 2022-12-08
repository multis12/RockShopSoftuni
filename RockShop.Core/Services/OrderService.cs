using RockShop.Core.Contracts;
using RockShop.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Core.Services
{
    public class OrderService : IOrderService
    {
        public Task<IEnumerable<Order>> All()
        {
            throw new NotImplementedException();
        }
    }
}
