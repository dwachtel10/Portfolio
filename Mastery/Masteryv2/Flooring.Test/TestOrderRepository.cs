using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.BLL;
using Flooring.Data.Factory;
using Flooring.Data.TestRepos;
using Flooring.Models;
using NUnit.Framework;

namespace Flooring.Test
{
    [TestFixture]
    public class TestOrderRepository
    {
        [Test]
        public void CanDisplayAndAddOrder()
        {
            
            OrderManager manager = new OrderManager();
            DateTime date = new DateTime(1986, 5, 11);
            Order newOrder = new Order {CustomerName = "Doug", OrderDate = date};
            manager.AddOrder(date, newOrder);
            var orderResponse = manager.ViewOrders(date);
            Assert.IsTrue(orderResponse.Success);
            Assert.IsTrue(orderResponse.orders.Count != 0);
        }

        [Test]
        public void CanDeleteOrder()
        {
            OrderManager manager = new OrderManager();
            DateTime date = new DateTime(1986, 5, 11);
            Order newOrder = new Order { CustomerName = "Doug", OrderDate = date };
            Order newOrder2 = new Order {CustomerName = "Steven", OrderDate = date};
            manager.AddOrder(date, newOrder);
            manager.AddOrder(date, newOrder2);
            var orderResponse = manager.ViewOrders(date);
            Assert.IsTrue(orderResponse.Success);
            int addCount = orderResponse.orders.Count;
            manager.RemoveOrder(date, newOrder);
            
            var removeResponse = manager.ViewOrders(date);
            Assert.IsTrue(removeResponse.Success);
            int removeCount = removeResponse.orders.Count;
            
            Assert.AreEqual(removeCount, 1);
            
        }

        [Test]
        public void CanEditOrder()
        {
            IOrderRepository repo = RepositoryFactory.CreateOrderRepo();
            
            
            OrderManager manager = new OrderManager();
            DateTime date = new DateTime(1986, 5, 11);
            Order newOrder = new Order { CustomerName = "Doug", OrderDate = date};
            manager.AddOrder(date, newOrder);
            var startingOrders = manager.ViewOrders(date).orders.Count;
            Order editedOrder = new Order {CustomerName = "Steven", OrderDate = date};
            manager.EditOrder(date, newOrder, editedOrder);
            var totalOrders = manager.ViewOrders(date).orders.Count;
            Assert.AreEqual(totalOrders, startingOrders);
            Assert.AreEqual(manager.ViewOrders(date).orders[0].CustomerName, "Steven");

            

            
        }

        [Test]
        public void CanGetOrderNumber()
        {
            
            OrderManager manager = new OrderManager();
            
            DateTime date = new DateTime(1986, 5, 11);
            
            Order newOrder1 = new Order {CustomerName = "Doug", OrderDate = date};
            Order newOrder2 = new Order { CustomerName = "Steven", OrderDate = date};
            manager.AddOrder(date, newOrder1);
            
            manager.AddOrder(date, newOrder2);
            //manager.GetOrderNumber(manager.ViewOrders(date).orders);
            List<Order> orders = manager.ViewOrders(date).orders;

            Assert.AreEqual(orders[0].OrderNumber, 1);
            Assert.AreEqual(orders[1].OrderNumber, 2);
            //manager.AddOrder(date, newOrder2);
            
            
            //Assert.AreEqual(newOrder2.OrderNumber, 2);

        }

        //        private const string _filePath =
        //            @"C:\_repos\douglas-wachtel-individual-work\Mastery\Masteryv2\DataFiles\Tests\OrderTest.txt";

        //        private const string _originalData =
        //            @"C:\_repos\douglas-wachtel-individual-work\Mastery\Masteryv2\DataFiles\Tests\OrderTestSeed.txt";

        //        [SetUp]
        //        public void SetUp()
        //        {
        //            if (File.Exists(_filePath))
        //            {
        //                File.Delete(_filePath);
        //            }

        //            File.Copy(_originalData, _filePath);
        //        }

        //        [Test]
        //        public void CanReadFromFile()
        //        {
        //            OrderManager repo = new OrderManager(@"C:\_repos\douglas-wachtel-individual-work\Mastery\Masteryv2\DataFiles\Tests\OrderTest.txt");

        //            var orders = repo.ViewOrders(DateTime.Now)



        //            Assert.AreEqual("Carpet", check.);
        //            Assert.AreEqual(2.25m, check.CostPerSquareFoot);
        //            Assert.AreEqual(2.10m, check.LaborPerSquareFoot);

        //        }
        //    }
        //}



        ////public void CanAddOrder()
        //        //{
        //        //    OrderManager manager = new OrderManager();
        //        //    Order order = new Order()
        //        //    {
        //        //        CustomerName = "Bernard",
        //        //        Area = 25,
        //        //        LaborCost = 45M,
        //        //        MaterialCost = 65M,
        //        //        OrderDate = DateTime.Today,
        //        //        Tax = 4.5M,
        //        //        OrderNumber = 1,
        //        //        Product = new Product(),
        //        //        State = new State(),
        //        //        Total = 750.5m
        //        //    };
        //        //    var response = manager.AddOrder(order, "Tile", "Ohio");
        //        //}

    }
}
