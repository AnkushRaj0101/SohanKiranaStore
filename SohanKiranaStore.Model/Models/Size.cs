using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohanKiranaStore.Model.Models
{
    public class Size
    {
        public int SizeId { get; set; }
        public string Description { get; set; } // E.g., "1 Liter", "500 ml", "1 Kg"

        // Navigation property for many-to-many relationship
        public ICollection<ProductSize> ProductSizes { get; set; }
    }
}
