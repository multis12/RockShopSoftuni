using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Infrastructure.Data
{
    public class AppUser : IdentityUser
    {
        public List<CartItem> UserProducts { get; set; } = new List<CartItem>();
    }
}
