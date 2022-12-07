using Microsoft.EntityFrameworkCore;
using RockShop.Core.Contracts;
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
    public class CartService : ICartService
    {
  
        private readonly IRepository repo;
        private readonly IStaffService staffService;

        public CartService(IRepository _repo, IStaffService _staffService)
        {
            repo = _repo;
            staffService = _staffService;
        }

        public async Task AddToCart(int id, string userId)
        {
            var acc = await repo.All<AppUser>()
                .Where(a => a.Id == userId)
                .Include(a => a.UserProducts)
                .FirstOrDefaultAsync();
            if (acc == null)
            {
                throw new ArgumentException("Invalid user ID");
            }
            var product = await repo.AllReadonly<Product>().FirstOrDefaultAsync(a => a.Id == id);

            if (product == null)
            {
                throw new ArgumentException("Invalid Book ID");
            }

            if (!acc.UserProducts.Any(m => m.ProductId == id))
            {
                acc.UserProducts.Add(new CartItem
                {
                    ProductId = product.Id,
                    AccountId = acc.Id,
                    Product = product,
                    AccountUser = acc
                });

                await repo.SaveChangesAsync();
            }
        }   

        public async Task<IEnumerable<ProductServiceModel>> GetCart(string userId)
        {
            var acc = await repo.AllReadonly<AppUser>()
                .Where(a => a.Id == userId)
                .Include(a => a.UserProducts)
                .ThenInclude(ap => ap.Product)
                .FirstOrDefaultAsync();

            if (acc == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            return acc.UserProducts
                .Select(p => new ProductServiceModel()
                {
                    Id = p.ProductId,
                    ImageUrl = p.Product.ImageUrl,
                    InStock = p.Product.InStock,
                    Name = p.Product.Name,
                    Price = p.Product.Price

                });
        }

        public async Task RemoveFromCart(int id, string userId)
        {
            var acc = await repo.All<AppUser>()
                .Where(a => a.Id == userId)
                .Include(a => a.UserProducts)
                .FirstOrDefaultAsync();

            if (acc == null)
            {
                throw new ArgumentException("Invalid user ID");
            }

            var product = acc.UserProducts.FirstOrDefault(p => p.ProductId == id);

            if (product != null)
            {
                acc.UserProducts.Remove(product);

                await repo.SaveChangesAsync();
            }
        }
    }
}
