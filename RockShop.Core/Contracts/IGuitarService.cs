using RockShop.Core.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockShop.Core.Contracts
{
    public interface IGuitarService
    {
        Task<IEnumerable<GuitarIndexModel>> LastSevenGuitars();
    }
}
