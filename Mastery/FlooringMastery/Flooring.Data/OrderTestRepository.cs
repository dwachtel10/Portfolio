using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Models;
using Flooring.Models.Interfaces;



namespace Flooring.Data
{
    public class OrderTestRepository : IOrderRepository
    {
        private static Order _order = new Order()
        {
            CustomerName = "TestCompany",
            State = "Ohio",
            ProductType = "TestProduct",
            Area = 5.25M,
            Date = 01011999

        };

        public Order LoadOrder(int Date, int OrderNumber)
        {
            return _order;
        }

        public void SaveOrder(Order order)
        {
            _order = order;
        }
    }


}
