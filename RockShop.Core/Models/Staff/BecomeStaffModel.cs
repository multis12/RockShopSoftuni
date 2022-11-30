using System.ComponentModel.DataAnnotations;

namespace RockShop.Core.Models.Admin
{
    public class BecomeStaffModel
    {
        [Required]
        [StringLength(15, MinimumLength = 7)]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } = null!;
    }
}
