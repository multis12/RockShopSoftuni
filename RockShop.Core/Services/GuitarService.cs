using Microsoft.EntityFrameworkCore;
using RockShop.Core.Contracts;
using RockShop.Core.Models.Guitar;
using RockShop.Infrastructure.Data;
using RockShop.Infrastructure.Data.Common;
using Type = RockShop.Infrastructure.Data.Type;

namespace RockShop.Core.Services
{
    public class GuitarService : IGuitarService
    {
        private readonly IRepository repo;

        public GuitarService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<GuitarCategoryModel>> AllCategories()
        {
            return await repo.AllReadonly<Category>()
                .OrderBy(c => c.Name)
                .Select(c => new GuitarCategoryModel() 
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<GuitarTypeModel>> AllTypes()
        {
            return await repo.AllReadonly<Type>()
                .OrderBy(t => t.Name)
                .Select(t => new GuitarTypeModel()
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

        public async Task<bool> TypeExists(int typeId)
        {
            return await repo.AllReadonly<Type>()
                .AnyAsync(t => t.Id == typeId);
        }

        public async Task<int> Create(GuitarModel model)
        {
            var guitar = new Guitar()
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
                Adapters = model.Adapters,
                Price = model.Price,
            };

            await repo.AddAsync(guitar);
            await repo.SaveChangesAsync();

            return guitar.Id;
        }

        public async Task<IEnumerable<GuitarIndexModel>> LastSevenGuitars()
        {
            return await repo.AllReadonly<Guitar>()
                .OrderByDescending(g => g.Id)
                .Select(g => new GuitarIndexModel()
                {
                    Id = g.Id,
                    ImageUrl = g.ImageUrl,
                    Name = g.Name
                })
                .Take(7)
                .ToListAsync();
        }

        public async Task<GuitarQueryModel> All(string? category = null, string? searchTerm = null, GuitarSorting sorting = GuitarSorting.Newest, int currentPage = 1, int guitarsPerPage = 1)
        {
            var result = new GuitarQueryModel();
            var guitars = repo.AllReadonly<Guitar>();

            if (string.IsNullOrEmpty(category) == false)
            {
                guitars = guitars.Where(g => g.Category.Name == category);
            }

            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";

                guitars = guitars.Where(g => EF.Functions.Like(g.Name, searchTerm) ||
                                    EF.Functions.Like(g.Description, searchTerm));
            }

            guitars = sorting switch
            {
                GuitarSorting.Price => guitars
                .OrderBy(g => g.Price),
                GuitarSorting.InStockFirst => guitars
                .OrderBy(g => g.InStock),
                _ => guitars.OrderByDescending(g => g.Id)
            };

            result.Guitars = await guitars
                .Skip((currentPage - 1) * guitarsPerPage)
                .Take(guitarsPerPage)
                .Select(g => new GuitarServiceModel()
                {
                    Id = g.Id,
                    ImageUrl = g.ImageUrl,
                    Price = g.Price,
                    InStock = g.InStock,
                    Name = g.Name
                })
                .ToListAsync();

            result.TotalGuitarsCount = await guitars.CountAsync();

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
    }
}
