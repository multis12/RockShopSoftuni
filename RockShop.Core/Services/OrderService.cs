using Microsoft.EntityFrameworkCore;
using RockShop.Core.Contracts;
using RockShop.Core.Models.Order;
using RockShop.Core.Models.Product;
using RockShop.Infrastructure.Data;
using RockShop.Infrastructure.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository repo;
        private readonly IStaffService staffService;

        public OrderService(IRepository _repo, IStaffService _staffService)
        {
            repo = _repo;
            staffService = _staffService;
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
    }
}
