using Microsoft.EntityFrameworkCore;
using RockShop.Core.Contracts;
using RockShop.Infrastructure.Data;
using RockShop.Infrastructure.Data.Common;

namespace RockShop.Core.Services
{
    public class StaffService : IStaffService
    {
        private readonly IRepository repo;

        public StaffService(IRepository _repo)
        {
            repo = _repo;
        }

        public Task Create(string userId, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsById(string userId)
        {
            return await repo.All<Staff>().AnyAsync(a => a.UserId == userId);
        }

        public Task<bool> UserHasGuitar(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserWithPhoneNumberExists(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
