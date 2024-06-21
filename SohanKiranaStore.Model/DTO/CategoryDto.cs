using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohanKiranaStore.Model.DTO
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageType { get; set; }
        public ICollection<ProductDto>? Products { get; set; }
    }
}
