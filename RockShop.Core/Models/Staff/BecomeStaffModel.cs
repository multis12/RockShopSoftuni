using System.ComponentModel.DataAnnotations;

namespace RockShop.Core.Models.Staff
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
