using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohanKiranaStore.Model.DTO
{
    public class DescriptionDto
    {
        public int DescriptionId { get; set; }
        public string ProductDescription { get; set; }
        public string Features { get; set; }
        public string OtherProductInfo { get; set; }
    }
}
