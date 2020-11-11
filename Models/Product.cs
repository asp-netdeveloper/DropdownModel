using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dropdownworking.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string productCode { get; set; }

        public bool Active { get; set; }
    }
}
