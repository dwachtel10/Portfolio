using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Models;

namespace Flooring.Data.ProdRepos
{
    public class OrderProdRepository : IOrderRepository
    {
        private const string FILENAME = @"C:\_repos\douglas-wachtel-individual-work\Mastery\Masteryv2\DataFiles\Orders_";
        private const string FILEEXT = ".txt";

        //List<Order> _filePath = new List<Order>();

        //public OrderProdRepository(string filepath)
        //{
        //    _filePath = filepath;
        //}

        //public List<Order> List()
        //{
        //    List<Order> orders = new List<Order>();

        //    using (StreamReader sr = new StreamReader(_filePath))
        //    {
        //        sr.ReadLine();
        //        string line;

        //        while ((line = sr.ReadLine())
        //               != null)
        //        {
        //            Order newOrder = new Order();

        //            string[] columns = line.Split(',');

        //            newOrder.OrderNumber = int.Parse(columns[0]);
        //            newOrder.CustomerName = columns[1];
        //            newOrder.StateName = columns[2];
        //            newOrder.ProductType = columns[3];
        //            newOrder.Area = decimal.Parse(columns[4]);

        //            orders.Add(newOrder);
        //        }
        //    }
        //    return orders;
        //}

        public void AddOrder(DateTime Date, Order order)
        {
            //using (StreamWriter sw = new StreamWriter(_filePath, true))
            //{
            //    string line = CreateCsvForOrder(order);
            //    sw.WriteLine(line);
            //}
            var orders = ReadFromFile(order.OrderDate);
            orders.Add(order);

            var fileName = FILENAME + order.OrderDate.ToString("MMddyyyy") + FILEEXT;

            WriteToFile(orders, fileName);

            


        }

        public void EditOrder(Order order, Order editedOrder)
        {
            //orders.Add(editedOrder);
            //_filePath.Remove(order);
            var orders = ReadFromFile(order.OrderDate);
            var orderToRemove = orders.FirstOrDefault(a => a.OrderNumber == order.OrderNumber);
            orders.Remove(orderToRemove);
            orders.Add(editedOrder);
            orders = orders.OrderBy(a => a.OrderNumber).ToList();

            var fileName = FILENAME + order.OrderDate.ToString("MMddyyyy") + FILEEXT;

            WriteToFile(orders, fileName);

           
        }

        public void DeleteOrder(Order order)
        {
            var orders = ReadFromFile(order.OrderDate);
            var orderToDelete =
                from o in orders
                where o.OrderDate == order.OrderDate && o.OrderNumber == order.OrderNumber
                select o;
            
            orders.Remove(orderToDelete.First());
            
            var fileName = FILENAME + order.OrderDate.ToString("MMddyyyy") + FILEEXT;

            WriteToFile(orders, fileName);
        }

        public List<Order> ListOrdersByDate(DateTime Date)
        {
            var orders = ReadFromFile(Date);
            return orders;
        }

        public int GetOrderNumber(DateTime Date)
        {
            var dateToCheck = (ReadFromFile(Date).Where(o => o.OrderDate == Date).Count());
            bool ordersForToday = dateToCheck != 0;
            if (ordersForToday)
            {
                return ReadFromFile(Date).Where(o => o.OrderDate == Date).Max(o => o.OrderNumber) + 1;
            }
            else
            {
                return 1;
            }

        }

        //private string CreateCsvforOrder(Order order)
        //{
        //    return string.Format($"#{order.OrderNumber}, {order.CustomerName}, {order.Product.ProductType}, {order.Area}");
        //}
        //private List<Order> View


        private List<Order> ReadFromFile(DateTime Date)
        {
            var fileName = FILENAME + Date.ToString("MMddyyyy") + FILEEXT;

            List<Order> orders = new List<Order>();

            if (File.Exists(fileName))
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    sr.ReadLine();

                    string inputLine = "";
                    while ((inputLine = sr.ReadLine()) != null)
                    {
                        State state = new State();
                        Product product = new Product() {};
                        
                        string[] inputParts = inputLine.Split(',');

                        Order newOrder = new Order()
                        {
                            

                            OrderDate = Date,
                            OrderNumber = int.Parse(inputParts[0]),
                            CustomerName = inputParts[1],
                            State = new State() {
                                StateName = inputParts[2],
                                StateAbbreviation = inputParts[3],
                                TaxRate = decimal.Parse(inputParts[4])
                            },
                            
                            Product = new Product()
                            {
                                ProductType = inputParts[5],
                                CostPerSquareFoot = decimal.Parse(inputParts[7]),
                                LaborPerSquareFoot = decimal.Parse(inputParts[8])
                                
                            },
                            
                            Area = decimal.Parse(inputParts[6]),
                            
                            Tax = decimal.Parse(inputParts[9]),
                            MaterialCost = decimal.Parse(inputParts[10]),
                            LaborCost = decimal.Parse(inputParts[11]),
                            Total = decimal.Parse(inputParts[12])


                        };

                        orders.Add(newOrder);
                    }
                }
            }

            return orders;
        }

        public void WriteToFile(List<Order> orders, string FileName)
        {
            using (StreamWriter sw = new StreamWriter(FileName, false))
            {
                sw.WriteLine("ORDER NUMBER,CUSTOMER NAME,STATE,STATEABBREV,TAXRATE,PRODUCT,AREA,COSTPSF,LABORPSF,TAX,TOTALMATS,TOTALLABOR,TOTALCOST");

                foreach (var order in orders)
                {
                    sw.WriteLine($"{order.OrderNumber},{order.CustomerName},{order.State.StateName},{order.State.StateAbbreviation},{order.State.TaxRate},{order.Product.ProductType},{order.Area},{order.Product.CostPerSquareFoot},{order.Product.LaborPerSquareFoot},{order.Tax},{order.MaterialCost},{order.LaborCost},{order.Total}");
                }
            }
        }
    }
}
