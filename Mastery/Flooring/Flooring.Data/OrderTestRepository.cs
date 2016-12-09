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
        public Dictionary<int, List<Order>> ordersByDate = new Dictionary<int, List<Order>>();
        private static List<Order> _order;

        public OrderTestRepository()
        {

            if (_order == null)
            {
                _order = new List<Order>()
                {
                    new Order()
                    {
                        CustomerName = "TestCompany",
                        State = "Ohio",
                        ProductType = "TestProduct",
                        Area = 5.25M,
                        OrderDate = 01011999,
                        Total = 250.00M,
                        OrderNumber = 1
                    },
                    new Order()
                    {
                        CustomerName = "TestCompany2",
                        State = "Indiana",
                        ProductType = "Granite",
                        Area = 4.25M,
                        OrderDate = 01011999,
                        Total = 750.00M,
                        OrderNumber = 2
                    }

                };
            }
            ordersByDate.Add(01011999, _order);


        }

        public Order LoadDate(int OrderDate)
        {
            Console.WriteLine(ordersByDate.Keys);
            return LoadDate(OrderDate);


        }

        public Order LoadOrder(int orderNumber)
    {
        return _order.FirstOrDefault(a => a.OrderNumber == orderNumber);
    }

    //public void SaveOrder(Order order)
    //{
    //    _order = order;
    //}
}


}
