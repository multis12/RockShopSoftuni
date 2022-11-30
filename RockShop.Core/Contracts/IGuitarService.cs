using RockShop.Core.Models.Product;

namespace RockShop.Core.Contracts
{
    public interface IGuitarService
    {
        Task<IEnumerable<GuitarIndexModel>> LastSevenGuitars();

        Task<IEnumerable<GuitarCategoryModel>> AllCategories();

        Task<IEnumerable<GuitarTypeModel>> AllTypes();

        Task<bool> CategoryExists(int categoryId);

        Task<bool> TypeExists(int categoryId);

        Task<int> Create(GuitarModel model);
    }
}
