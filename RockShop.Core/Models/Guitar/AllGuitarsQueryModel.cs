using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Core.Models.Guitar
{
    public class AllGuitarsQueryModel
    {
        public const int GuitarsPerPage = 3;

        public string? Category { get; set; }

        public string? Type { get; set; }

        public string? SearchTerm { get; set; }

        public GuitarSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalGuitarsCount { get; set; }

        public IEnumerable<string> Categories { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<string> Types { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<GuitarServiceModel> Guitars { get; set; } = Enumerable.Empty<GuitarServiceModel>();
    }
}
