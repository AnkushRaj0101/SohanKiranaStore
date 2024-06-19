using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohanKiranaStore.Model.DTO
{
    public class ProductDto
    {

        public int ProductId { get; set; }
        public string Name { get; set; }
        public List<SizeDto> Sizes { get; set; }
        public int CategoryId { get; set; }
        public DescriptionDto Description { get; set; }
    }
}
