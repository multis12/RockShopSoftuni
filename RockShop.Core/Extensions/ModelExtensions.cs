using Microsoft.Extensions.Primitives;
using RockShop.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Core.Extensions
{
    public static class ModelExtensions
    {
        public static string GetInformation(this IProductModel product)
        {
            string info = string.Empty;
            StringBuilder sb = new StringBuilder();
            sb.Append(product.Name.Replace(" ", "-"));

            return sb.ToString();
        }
    }
}
