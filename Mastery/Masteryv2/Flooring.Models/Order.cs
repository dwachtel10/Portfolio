using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flooring.Models
{
    public class Order
    {
        public State State { get; set; }
        public Product Product { get; set; }
        public string CustomerName { get; set; }
        
       
        public decimal Area { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        
       
        public decimal MaterialCost { get; set; }
        public decimal LaborCost { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }

        
    }
}
