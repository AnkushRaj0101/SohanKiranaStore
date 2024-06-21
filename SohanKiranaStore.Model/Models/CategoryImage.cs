using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohanKiranaStore.Model.Models
{
    public class CategoryImage
    {
        public int Id { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageType { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
