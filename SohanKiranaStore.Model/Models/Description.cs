using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SohanKiranaStore.Model.Models
{
    public class Description
    {
        public int DescriptionId { get; set; }
        public string? ProductDescription { get; set; }
        public string? Features { get; set; }
        public string? OtherProductInfo { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
