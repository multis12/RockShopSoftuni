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

        public async Task Create(string userId, string phoneNumber)
        {
            var staff = new Staff()
            {
                AccountId = userId,
                PhoneNumber = phoneNumber
            };
            await repo.AddAsync(staff);
            await repo.SaveChangesAsync();
        }

        public async Task<bool> ExistsById(string userId)
        {
            return await repo.All<Staff>().AnyAsync(a => a.AccountId == userId);
        }

        //TODO: IMPLEMENT SHOPPING CART!
        //public Task<bool> UserHasGuitar(string userId)
        //{
        //    return await repo.All<Staff>().AnyAsync(a => a.R == phoneNumber); 
        //}

        public async Task<bool> UserWithPhoneNumberExists(string phoneNumber)
        {
            return await repo.All<Staff>().AnyAsync(a => a.PhoneNumber == phoneNumber);
        }
    }
}
