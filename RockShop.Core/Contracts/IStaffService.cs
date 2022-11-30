namespace RockShop.Core.Contracts
{
    public interface IStaffService
    {
        Task<bool> ExistsById(string userId);

        Task<bool> UserWithPhoneNumberExists(string phoneNumber);

        //Task<bool> UserHasGuitar(string userId);

        Task Create(string userId, string phoneNumber);
    }
}
