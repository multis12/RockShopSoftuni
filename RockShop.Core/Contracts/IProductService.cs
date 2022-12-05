
using RockShop.Core.Models.Product;

namespace RockShop.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductIndexModel>> LastSevenProducts();

        Task<IEnumerable<ProductCategoryModel>> AllCategories();

        Task<IEnumerable<ProductTypeModel>> AllTypes();

        Task<bool> CategoryExists(int categoryId);

        Task<bool> TypeExists(int? typeId);

        Task<int> Create(ProductModel model);

        Task<ProductQueryModel> All(
            string? category = null,
            string? searchTerm = null,
            ProductSorting sorting = ProductSorting.Newest,
            int currentPage = 1,
            int productsPerPage = 1);

        Task<IEnumerable<string>> AllCategoriesNames();

        Task<IEnumerable<string>> AllTypesNames();

        Task<ProductDetailsModel> ProductDetailsById(int Id);

        Task<bool> Exists(int Id);

        Task Edit(int productId, ProductModel model);

        Task<int> GetProductCategoryId(int productId);

        Task<int?> GetProductTypeId(int productId);

        Task Delete(int productId);

    }
}
