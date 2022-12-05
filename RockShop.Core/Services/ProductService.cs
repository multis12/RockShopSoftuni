using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RockShop.Core.Contracts;
using RockShop.Core.Models.Product;
using RockShop.Infrastructure.Data;
using RockShop.Infrastructure.Data.Common;
using Type = RockShop.Infrastructure.Data.Type;

namespace RockShop.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repo;
        private readonly IStaffService staffService;

        public ProductService(IRepository _repo, IStaffService _staffService)
        {
            repo = _repo;
            staffService = _staffService;
        }

        public async Task<IEnumerable<ProductCategoryModel>> AllCategories()
        {
            return await repo.AllReadonly<Category>()
                .OrderBy(c => c.Name)
                .Select(c => new ProductCategoryModel() 
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ProductTypeModel>> AllTypes()
        {
            return await repo.AllReadonly<Type>()
                .OrderBy(t => t.Name)
                .Select(t => new ProductTypeModel()
                {
                    Id = t.Id,
                    Name = t.Name
                })
                .ToListAsync();
        }

        public async Task<bool> CategoryExists(int categoryId)
        {
            return await repo.AllReadonly<Category>()
                .AnyAsync(c => c.Id == categoryId);
        }

        public async Task<bool> TypeExists(int? typeId)
        {
            return await repo.AllReadonly<Type>()
                .AnyAsync(t => t.Id == typeId);
        }

        public async Task<int> Create(ProductModel model)
        {
            var product = new Product()
            {
                Name = model.Name,
                CategoryId = model.CategoryId,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                TypeId = model.TypeId,
                Neck = model.Neck,
                Body = model.Body,
                InStock = model.InStock,
                Bridge = model.Bridge,
                Frets = model.Frets,
                Holes = model.Holes,
                Tune = model.Tune,
                Adapters = model.Adapters,
                Price = model.Price
            };

            await repo.AddAsync(product);
            await repo.SaveChangesAsync();

            return product.Id;
        }

        public async Task<IEnumerable<ProductIndexModel>> LastSevenProducts()
        {
            return await repo.AllReadonly<Product>()
                .Where(g => g.IsActive)
                .OrderByDescending(g => g.Id)
                .Select(g => new ProductIndexModel()
                {
                    Id = g.Id,
                    ImageUrl = g.ImageUrl,
                    Name = g.Name
                })
                .Take(7)
                .ToListAsync();
        }

        public async Task<ProductQueryModel> All(string ? category = null, string? searchTerm = null
            , ProductSorting sorting = ProductSorting.Newest, int currentPage = 1, int guitarsPerPage = 1)
        {
            var result = new ProductQueryModel();
            var products = repo.AllReadonly<Product>()
                .Where(p => p.IsActive);

            if (string.IsNullOrEmpty(category) == false)
            {
                products = products.Where(g => g.Category.Name == category);
            }
            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";

                products = products.Where(g => EF.Functions.Like(g.Name, searchTerm) ||
                                    EF.Functions.Like(g.Description, searchTerm));
            }

            products = sorting switch
            {
                ProductSorting.Price => products
                .OrderBy(g => g.Price),
                ProductSorting.InStockFirst => products
                .OrderBy(g => g.InStock),
                _ => products.OrderByDescending(g => g.Id)
            };

            result.Guitars = await products
                .Skip((currentPage - 1) * guitarsPerPage)
                .Take(guitarsPerPage)
                .Select(g => new ProductServiceModel()
                {
                    Id = g.Id,
                    ImageUrl = g.ImageUrl,
                    Price = g.Price,
                    InStock = g.InStock,
                    Name = g.Name
                })
                .ToListAsync();

            result.TotalGuitarsCount = await products.CountAsync();

            return result;
        }

        public async Task<IEnumerable<string>> AllCategoriesNames()
        {
            return await repo.AllReadonly<Category>()
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllTypesNames()
        {
            return await repo.AllReadonly<Type>()
                .Select(t => t.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<ProductDetailsModel> ProductDetailsById(int Id)
        {
            return await repo.AllReadonly<Product>()
                .Where(g => g.IsActive)
                .Where(g => g.Id == Id)
                .Select(g => new ProductDetailsModel()
                {
                    Id = g.Id,
                    Category = g.Category.Name,
                    Body = g.Body,
                    Name = g.Name,
                    ImageUrl = g.ImageUrl,
                    Adapters = g.Adapters,
                    InStock = g.InStock,
                    Bridge = g.Bridge,
                    Frets = g.Frets,
                    Neck = g.Neck,
                    Price = g.Price,
                    Holes = g.Holes,
                    Tune = g.Tune,
                    Type = g.Type.Name,
                    Description = g.Description
                })
                .FirstAsync();
        }

        public async Task<bool> Exists(int Id)
        {
            return await repo.AllReadonly<Product>()
                .AnyAsync(g => g.Id == Id && g.IsActive);
        }

        public async Task Edit(int productId, ProductModel model)
        {
            var product = await repo.GetByIdAsync<Product>(productId);

            product.Description = model.Description;
            product.Name = model.Name;
            product.ImageUrl = model.ImageUrl;
            product.Adapters = model.Adapters;
            product.InStock = model.InStock;
            product.Bridge = model.Bridge;
            product.Frets = model.Frets;
            product.Neck = model.Neck;
            product.Holes = model.Holes;
            product.Tune = model.Tune;
            product.Price = model.Price;
            product.CategoryId = model.CategoryId;
            product.TypeId = model.TypeId;

            await repo.SaveChangesAsync();
        }

        public async Task<int> GetProductCategoryId(int productId)
        {
            return (await repo.GetByIdAsync<Product>(productId)).CategoryId;
        }

        public async Task<int?> GetProductTypeId(int productId)
        {
            return (await repo.GetByIdAsync<Product>(productId)).TypeId;
        }

        public async Task Delete(int productId)
        {
            var product = await repo.GetByIdAsync<Product>(productId);
            product.IsActive = false;

            await repo.SaveChangesAsync();
        }
    }
}
