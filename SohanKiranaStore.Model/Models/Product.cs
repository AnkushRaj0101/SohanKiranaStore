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
        public string? Name { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public Description? Description { get; set; }

        public ICollection<ProductSize>? ProductSizes { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime UpdatedBy { get; set; }
    }


}
