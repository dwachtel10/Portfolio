using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Models;
using NUnit.Framework;

namespace Flooring.Data.TestRepos
{
    public class OrderTestRepository : IOrderRepository
    {
        private static List<Order> _orders;

        public OrderTestRepository()
        {

            if (_orders == null)
            {
                _orders = new List<Order>()
                {
                    new Order()
                    {
                        CustomerName = "TestCompany",
                        State = new State()
                        {
                            StateName = "Ohio",
                            StateAbbreviation = "OH",
                            TaxRate = .0625M
                        },
                        Product = new Product()
                        {
                            ProductType = "Carpet",
                CostPerSquareFoot = 2.25M,
                LaborPerSquareFoot = 2.10M
                        },
                        Area = 5.25M,
                        OrderDate = new DateTime(1999,01,01),
                        Total = 250.00M,
                        OrderNumber = 1
                        
                    },
                    new Order()
                    {
                        CustomerName = "TestCompany2",
                        State = new State()
                        {
                           StateAbbreviation = "IN",
                StateName = "Indiana",
                TaxRate = .06M
                        },
                        Product = new Product()
                        {
                            ProductType = "Laminate",
                CostPerSquareFoot = 1.75M,
                LaborPerSquareFoot = 2.10M
                        },
                        Area = 4.25M,
                        OrderDate = new DateTime(1999,01,01),
                        Total = 750.00M,
                        OrderNumber = 2
                        
                    }

                };
            }
        }

        



        public void AddOrder(DateTime Date,
            Order order)
        {
            order.OrderNumber = GetOrderNumber(Date);
            _orders.Add(order);
            


        }

        public void EditOrder(Order order, Order editedOrder)
        {
            _orders.Add(editedOrder);
            _orders.Remove(order);
            
        }

        public void DeleteOrder(Order order)
        {
            var orderToDelete = 
                //_orders.Where(o => o.OrderDate == order.OrderDate && o.OrderNumber == order.OrderNumber).FirstOrDefault();
                
              from o in _orders
              where o.OrderDate == order.OrderDate && o.OrderNumber == order.OrderNumber
              select o;


            _orders.Remove(orderToDelete.FirstOrDefault());
        }

        public List<Order> ListOrdersByDate(DateTime Date)
        {
            var orders = from o in _orders
                where o.OrderDate == Date

                select o;

            return orders.ToList();
        }

        public int GetOrderNumber(DateTime Date)
        {
            bool ordersForToday = (_orders.Where(o => o.OrderDate == Date).Count()) != 0;
            if (ordersForToday)
            {
                return _orders.Where(o => o.OrderDate == Date).Max(o => o.OrderNumber) + 1;
            }
            else
            {
                return 1;
            }

        }

        //public Order RetrieveOrder(DateTime Date, int orderNumber)
        //{
        //    var orders = _orders;
        //    var selection = from o in _orders
        //                    .Where(orders.OrderDate == Date)
        //}



        //public Order GetOrderByNumber(int orderNumber, List<Order> )
        //{
        //    return 
        //}
    }
}

       

    
      

