using RockShop.Core.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Core.Contracts
{
    public interface ICartService
    {
        Task AddToCart(int id, string userId);

        Task<IEnumerable<ProductServiceModel>> GetCart(string userId);

        Task RemoveFromCart(int id, string userId);
    }
}
