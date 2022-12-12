namespace RockShop.Core.Contracts
{
    public interface IStaffService
    {
        Task<bool> ExistsById(string userId);

        Task<bool> UserWithPhoneNumberExists(string phoneNumber);

        Task Create(string userId, string phoneNumber);
    }
}
