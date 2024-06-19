using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohanKiranaStore.Model.Models
{
    public class Product

    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        // Foreign key
        public int CategoryId { get; set; }
        // Navigation property
        public Category Category { get; set; }

        // Navigation property for one-to-one relationship
        public Description Description { get; set; }

        // Navigation property for many-to-many relationship
        public ICollection<ProductSize> ProductSizes { get; set; }
    }


}
