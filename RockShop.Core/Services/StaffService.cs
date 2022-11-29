using Microsoft.EntityFrameworkCore;
using RockShop.Core.Contracts;
using RockShop.Infrastructure.Data;
using RockShop.Infrastructure.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Core.Services
{
    public class StaffService : IStaffService
    {
        private readonly IRepository repo;

        public StaffService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<bool> ExistsById(string userId)
        {
            return await repo.All<Staff>().AnyAsync(a => a.UserId == userId);
        }
    }
}
