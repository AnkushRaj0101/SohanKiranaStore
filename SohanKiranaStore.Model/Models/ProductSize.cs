using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohanKiranaStore.Model.Models
{
    public class ProductSize
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int SizeId { get; set; }
        public Size Size { get; set; }

        public decimal Price { get; set; }

        // You can add additional properties here if needed, e.g., Stock, Price for specific size, etc.
    }
}
