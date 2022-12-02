using System.ComponentModel.DataAnnotations;

namespace RockShop.Core.Models.Guitar
{
    public class GuitarTypeModel
    {
        
        public int Id { get; set; }

        
        public string Name { get; set; } = null!;
    }
}
