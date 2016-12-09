using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flooring.Models
{
    public class Product
    {
        public string ProductType { get; set; }
        public decimal PricePerSquareFoot { get; set; }
        public decimal LaborPerSquareFoot { get; set; }
    }
}
