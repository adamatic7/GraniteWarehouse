using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraniteWarehouse.Models.ViewModels
{
    public class ProductViewModels
    {
        public Products Products { get; set; }
        public IEnumerable<ProductTypes> ProductType { get; set; }
        public IEnumerable<SpecialTags> SpecialTags { get; set; }

    }
}
