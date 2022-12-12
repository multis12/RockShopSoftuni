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

        /// <summary>
        /// Creates new staff
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Checks if the staff exist by the Id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<bool> ExistsById(string userId)
        {
            return await repo.All<Staff>().AnyAsync(a => a.AccountId == userId);
        }

        /// <summary>
        /// Checks if the Phone number exists in the staff
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public async Task<bool> UserWithPhoneNumberExists(string phoneNumber)
        {
            return await repo.All<Staff>().AnyAsync(a => a.PhoneNumber == phoneNumber);
        }
    }
}
