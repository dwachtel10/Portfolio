using Flooring.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Data.Factory;
using Flooring.Data.TestRepos;
using Flooring.Models;


namespace Flooring.BLL
{
    public class OrderManager
    {

        //private string _filePath;

        //public OrderManager(string filepath)
        //{
            //_filePath = filepath;
        //}

            //works
        public ViewOrderResponses ViewOrders(DateTime Date)
        {
            IOrderRepository repo = RepositoryFactory.CreateOrderRepo();
            ViewOrderResponses response = new ViewOrderResponses();
            var orders = repo.ListOrdersByDate(Date);
            
            if (orders.Count == 0)
            {
                response.Success = false;
                response.Message = "No orders found.";

            }
            
            else
            {
                response.Success = true;
                response.orders = orders;
            }


            return response;
        }

        //works
        public void AddOrder(DateTime Date, Order order)
        {
            
            IOrderRepository repo = RepositoryFactory.CreateOrderRepo();
            AddOrderResponses response = new AddOrderResponses();
            order.OrderNumber = GetOrderNumber(repo.ListOrdersByDate(Date));
            repo.AddOrder(Date, order);
            
            response.Success = true;

            
        }

        public void EditOrder(DateTime Date, Order order, Order editedOrder)
        {
            IOrderRepository repo = RepositoryFactory.CreateOrderRepo();
            EditOrderResponses response = new EditOrderResponses();
            repo.EditOrder(order, editedOrder);
            

            response.Success = true;
        }

        public int GetOrderNumber(List<Order> order)
        {
            if (order.Count != 0)
            {
                return order.Max(o => o.OrderNumber) + 1;
            }
            else
            {
                return 1;
            }
            //var dateToCheck = (ReadFromFile(Date).Where(o => o.OrderDate == Date).Count());
            //bool ordersForToday = dateToCheck != 0;
            //if (ordersForToday)
            //{
            //    return ReadFromFile(Date).Where(o => o.OrderDate == Date).Max(o => o.OrderNumber) + 1;
            //}
            //else
            //{
            //    return 1;
            //}
        }

        public void RemoveOrder(DateTime Date, Order order)
        {
            IOrderRepository repo = RepositoryFactory.CreateOrderRepo();
            RemoveOrderResponses response = new RemoveOrderResponses();
            repo.DeleteOrder(order);
            response.Success = true;
        }

        public State GetStateInfo(string statename)
        {
            IStateRepository repo = RepositoryFactory.CreateStateRepo();
            State state = repo.GetState(statename);
            return state;

        }

        public Product GetProductInfo(string productType)
        {
            IProductRepository repo = RepositoryFactory.CreateProductRepo();
            Product product = repo.GetProduct(productType);
            return product;
        }

        //public int GetOrderNumber(Order order)
        //{
        //    IOrderRepository repo = RepositoryFactory.CreateOrderRepo();
        //    var highestOrder = _order.Max(o => o.OrderNumber);

        //}

    }
}
