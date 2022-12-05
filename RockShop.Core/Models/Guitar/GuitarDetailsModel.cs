using System.ComponentModel.DataAnnotations;

namespace RockShop.Core.Models.Guitar
{
    public class GuitarDetailsModel : GuitarServiceModel
    {
        
        public string Neck { get; set; } = null!;
     
        public string Body { get; set; } = null!;

        public string Bridge { get; set; } = null!;

        public int Frets { get; set; }

        public string Category { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Type { get; set; } = null!;

        public string Adapters { get; set; } = null!;
    }
}
