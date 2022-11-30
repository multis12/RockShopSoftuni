using Microsoft.EntityFrameworkCore;
using RockShop.Core.Contracts;
using RockShop.Core.Models.Product;
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
                .OrderByDescending(h => h.Id)
                .Select(h => new GuitarIndexModel()
                {
                    Id = h.Id,
                    ImageUrl = h.ImageUrl,
                    Name = h.Name
                })
                .Take(7)
                .ToListAsync();
        }
    }
}
