using RockShop.Core.Models.Product;

namespace RockShop.Core.Contracts
{
    public interface IGuitarService
    {
        Task<IEnumerable<GuitarIndexModel>> LastSevenGuitars();
    }
}
