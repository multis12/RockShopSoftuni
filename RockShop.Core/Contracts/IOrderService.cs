using RockShop.Core.Models.Order;
using RockShop.Core.Models.Product;
using RockShop.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Core.Contracts
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderServiceModel>> All();

        Task<int> Checkout(string userId, OrderViewModel model);

        Task Delete(int orderId);

        Task<bool> Exists(int id);

        Task<OrderServiceModel> OrderDetailsById(int Id);
    }
}
