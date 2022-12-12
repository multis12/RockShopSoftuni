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
        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<Order>()
                        .AnyAsync(o => o.Id == id);
        }
    }
}
