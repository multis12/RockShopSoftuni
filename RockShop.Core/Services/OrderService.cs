using Microsoft.EntityFrameworkCore;
using RockShop.Core.Contracts;
using RockShop.Core.Models.Order;
using RockShop.Core.Models.Product;
using RockShop.Infrastructure.Data;
using RockShop.Infrastructure.Data.Common;

namespace RockShop.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository repo;

        public OrderService(IRepository _repo)
        {
            repo = _repo;
        }


        /// <summary>
        /// Returns all orders
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<OrderServiceModel>> All()
        {
            var result = new List<OrderServiceModel>();

            var products = repo.All<OrderUserProducts>();

           result = await repo.All<Order>()
                .Where(x => x.IsCompleted == false)
                .Include(x => x.OrderUsersProducts)
                .Select(x => new OrderServiceModel()
                {
                    Address = x.Address,
                    FirstName = x.FirstName,
                    Id = x.Id,
                    PhoneNumber = x.PhoneNumber,
                    SecondName = x.SecondName

                }).ToListAsync();


            return result;

        }

        /// <summary>
        /// Clears the current cart and creates new order
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<int> Checkout(string userId, OrderViewModel model)
        {
            var acc = await repo.All<AppUser>()
                .Where(a => a.Id == userId)
                .Include(a => a.UserProducts)
                .FirstOrDefaultAsync();

            var order = new Order()
            {
                FirstName = model.FirstName,
                SecondName = model.SecondName,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                Acc = acc,
                AccountId = userId
            };
            var accProducts = repo.All<CartItem>()
                .Where(a => a.AccountId == userId);

            order.OrderUsersProducts.AddRange(await repo.All<CartItem>()
                .Where(a => a.AccountId == userId)
                .Select(a => new OrderUserProducts()
                {
                    AccountId = a.AccountId,
                    AccountUser = acc,
                    Product = a.Product,
                    ProductId = a.ProductId
                })
                .ToListAsync());

            await repo.AddAsync(order);
            

            foreach (var userProduct in accProducts)
            {
                acc.UserProducts.Remove(userProduct);
            }
            await repo.SaveChangesAsync();

            return order.Id;
        }

        /// <summary>
        /// Deletes the order by the given Id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public async Task Delete(int orderId)
        {
            var order = await repo.All<Order>()
                .Where(o => o.Id == orderId)
                .Include(o => o.OrderUsersProducts)
                .FirstOrDefaultAsync();

            var accId = await repo.AllReadonly<AppUser>().Where(a => a.Id == order.AccountId).FirstOrDefaultAsync();

            var products = repo.All<OrderUserProducts>()
                            .Where(p => p.AccountId == accId.Id);

            order.IsCompleted = true;

            foreach (var userProduct in products)
            {
                repo.Delete(userProduct);
            }
            await repo.SaveChangesAsync();

        }
        /// <summary>
        /// Returns Details for the order by the Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<OrderServiceModel> OrderDetailsById(int Id)
        {
            var result = await repo.AllReadonly<Order>()
                .Include(g => g.OrderUsersProducts)
                .Where(g => g.Id == Id)
                .Select(g => new OrderServiceModel()
                {
                    Id = g.Id,
                    AccountId = g.AccountId,
                    Address = g.Address,
                    FirstName = g.FirstName,
                    SecondName = g.SecondName,
                    PhoneNumber = g.PhoneNumber,
                })
                .FirstAsync();
            var userProducts = repo.AllReadonly<OrderUserProducts>().Where(o => o.AccountId == result.AccountId);

            result.OrderProducts = await userProducts.Select(r => new OrderProductServiceModel
            {
                AccountId = r.AccountId,
                ProductId = r.ProductId
            }).ToListAsync();

            return result;
        }
        /// <summary>
        /// Checks if the order exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<Order>()
                        .AnyAsync(o => o.Id == id);
        }
    }
}
