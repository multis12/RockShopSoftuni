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
    public class GuitarService : IGuitarService
    {
        private readonly IRepository repo;

        public GuitarService(IRepository _repo)
        {
            repo = _repo;
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
