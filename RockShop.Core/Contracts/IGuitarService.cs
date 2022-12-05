using RockShop.Core.Models.Guitar;

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

        Task<GuitarQueryModel> All(
            string? category = null,
            string? searchTerm = null,
            GuitarSorting sorting = GuitarSorting.Newest,
            int currentPage = 1,
            int guitarsPerPage = 1);

        Task<IEnumerable<string>> AllCategoriesNames();
        Task<IEnumerable<string>> AllTypesNames();

        Task<GuitarDetailsModel> GuitarDetailsById(int Id);

        Task<bool> Exists(int Id);
    }
}
