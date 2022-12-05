using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Core.Models.Product
{
    public class AllProductsQueryModel
    {
        public const int ProductsPerPage = 3;

        public string? Category { get; set; }

        public string? Type { get; set; }

        public string? SearchTerm { get; set; }

        public ProductSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalProductsCount { get; set; }

        public IEnumerable<string> Categories { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> Types { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<ProductServiceModel> Products { get; set; } = Enumerable.Empty<ProductServiceModel>();
    }
}
