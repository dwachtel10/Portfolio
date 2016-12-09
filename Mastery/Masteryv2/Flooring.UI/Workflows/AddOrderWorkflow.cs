using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.BLL;
using Flooring.Data.Factory;
using Flooring.Data.ProdRepos;
using Flooring.Data.TestRepos;
using Flooring.Models;

namespace Flooring.UI.Workflows
{
    public class AddOrderWorkflow
    {
        public void Execute()
        {
            OrderManager manager = new OrderManager();

            Console.Clear();
            Console.WriteLine("Add New Order");
            Console.WriteLine(ConsoleIO.HorizontalLine);

            Order order = new Order();
            order.OrderDate = DateTime.Today;

            State state = new State();
            Product product = new Product();

            
            order.CustomerName = ConsoleIO.GetRequiredStringFromUser("Customer Name: ");
            order.State= ConsoleIO.GetRequiredStateFromUser("State (Ohio, Indiana, Michigan, or Pennsylvania): ");
            order.Product = ConsoleIO.GetRequiredProductFromUser("What product? Choose from Carpet, Tile, Laminate, or Wood. ");
            order.Area = ConsoleIO.GetRequiredDecimalFromUser("How much area, in square feet, are you planning to cover?: ");
            product = manager.GetProductInfo(order.Product.ProductType);
            state = manager.GetStateInfo(order.State.StateName);
            order.Product.ProductType = product.ProductType;
            order.Product.CostPerSquareFoot = product.CostPerSquareFoot;
            order.Product.LaborPerSquareFoot = product.LaborPerSquareFoot;
            order.State.StateAbbreviation = state.StateAbbreviation;
            order.State.TaxRate = state.TaxRate*.01M;
            order.MaterialCost = order.Product.CostPerSquareFoot*order.Area;
            order.LaborCost = order.Product.LaborPerSquareFoot*order.Area;
            
            
            order.Tax = order.MaterialCost*state.TaxRate*.01M;
            order.Total = order.MaterialCost + order.LaborCost + order.Tax;

            
            Console.WriteLine();
            Console.WriteLine(ConsoleIO.HorizontalLine);

            Console.WriteLine($"{order.CustomerName}, {order.State.StateName}, {order.Product.ProductType}, {order.Area}");

            if (ConsoleIO.GetYesNoAnswerFromuser("Add the following information? Enter Y for Yes; any other key for No.") == "Y")
            {
                //IOrderRepository repo = RepositoryFactory.CreateOrderRepo();
                manager.AddOrder(order.OrderDate, 
                    order);
                //order.GetOrderNumber();
                
                Console.WriteLine("Order Added.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Add order cancelled.");
                Console.ReadLine();
            }
            Console.Clear();
            MainMenu.Main();
        }
    }
}
