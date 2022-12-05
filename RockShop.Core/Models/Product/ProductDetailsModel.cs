using System.ComponentModel.DataAnnotations;

namespace RockShop.Core.Models.Product
{
    public class ProductDetailsModel : ProductServiceModel
    {
        
        public string? Neck { get; set; }
     
        public string? Body { get; set; }

        public string? Bridge { get; set; }

        public int? Frets { get; set; }

        public string? Tune { get; set; }

        public int? Holes { get; set; }

        public string? Category { get; set; }

        public string? Description { get; set; }

        public string? Type { get; set; }

        public string? Adapters { get; set; }
    }
}
