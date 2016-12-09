using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.BLL;
using Flooring.Data.Factory;
using Flooring.Models;


namespace Flooring.UI
{
    public class ConsoleIO
    {
       OrderManager manager = new OrderManager();
        public const string HorizontalLine = "==========================================================";

        public static void DisplayOrderDetails(Order order)
        {
            //Console.WriteLine($"#{order.OrderNumber}");
            Console.WriteLine($"Order Date: {order.OrderDate}");
            Console.WriteLine($"Customer Name:{order.CustomerName}");
            //Console.WriteLine($"Product Ordered: {order.Product.ProductType}");
        }

        public static void ErrorLogging()
        {
            using (
                StreamWriter sw =
                    File.AppendText(
                        @"C:\_repos\douglas-wachtel-individual-work\Mastery\Masteryv2\DataFiles\ErrorLog.txt"))
            {
                sw.WriteLine($"{DateTime.Now}:Invalid input error occurred.");
            }
        }

        public static void FullOrderDetails(Order order)
        {
            IStateRepository repo = RepositoryFactory.CreateStateRepo();
            IProductRepository prodRepo = RepositoryFactory.CreateProductRepo();

            State state = new State();

            state = repo.GetState(order.State.StateName);
            
            Product product = new Product();

            product = prodRepo.GetProduct(order.Product.ProductType);
           

            
            
            Console.WriteLine($"{order.OrderDate}");
            Console.WriteLine($"Order Number: {order.OrderNumber}");
            Console.WriteLine($"Customer Name: {order.CustomerName}");
            Console.WriteLine($"State: {state.StateName}");
            Console.WriteLine($"State abbreviation: {state.StateAbbreviation}");
            Console.WriteLine($"Tax rate: {state.TaxRate}");
            Console.WriteLine($"Product Ordered: {product.ProductType}");
            Console.WriteLine($"Area Ordered (square feet): {order.Area}");
            Console.WriteLine($"Product Cost per square foot: {product.CostPerSquareFoot:C}");
            Console.WriteLine($"Labor Cost per square foot: {product.LaborPerSquareFoot:C}");
            Console.WriteLine($"Total Material Cost: {product.CostPerSquareFoot * order.Area:C}");
            Console.WriteLine($"Total Labor Cost: {product.LaborPerSquareFoot * order.Area:C}");
            Console.WriteLine($"Total Tax: {product.CostPerSquareFoot * order.Area * state.TaxRate*.01M:C}");
            Console.WriteLine(
                $"Order Total: {(product.CostPerSquareFoot*order.Area) + (product.LaborPerSquareFoot*order.Area) + (product.CostPerSquareFoot*order.Area*state.TaxRate*.01M):C}");
           

        }

        public static string GetRequiredStringFromUser(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("You must enter valid text.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
           
            return input;
        }

        public static int GetRequiredIntFromUser(string prompt)
        {
            int numberResult;
            Console.WriteLine(prompt);
            while (!int.TryParse(prompt, out numberResult) || numberResult <= 0) 
            {
                
                Console.WriteLine("Enter a positive number.");
                prompt = Console.ReadLine();
                
            } 
            return numberResult;
        }

        public static decimal GetRequiredDecimalFromUser(string prompt)
        {
            decimal numberResult;
            Console.WriteLine(prompt);

            while (!decimal.TryParse(prompt, out numberResult) || numberResult <= 0)
            {
                
                Console.WriteLine("Enter a positive number.");
                prompt = Console.ReadLine();

            }
            return numberResult;
        }

        public static DateTime GetRequiredDateTimeFromUser(string prompt)
        {
            
            DateTime dateResult;

            if (!DateTime.TryParse(prompt, out dateResult))
            {

                Console.WriteLine(prompt);
                prompt = Console.ReadLine();
            }
            

            return dateResult;
        }

        public static string GetYesNoAnswerFromuser(string prompt)
        {
            while (true)
            {
                Console.Write(prompt + " (Y/N)? ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("You must enter Y/N.");
                    Console.WriteLine("Press any key to continue.");
                    ConsoleIO.ErrorLogging();
                    Console.ReadKey();
                }
                else
                {
                    if (input != "Y" && input != "N")
                    {
                        Console.WriteLine("You must enter Y/N.");
                        Console.WriteLine("Press any key to continue.");
                        ConsoleIO.ErrorLogging();
                        Console.ReadKey();
                    }
                    return input;
                }
            }
        }

        public static string GetEditStringName(string prompt, Order order)
        {
            Console.WriteLine(prompt);
            string UserInput = Console.ReadLine();
            string CustomerName;

            if (string.IsNullOrEmpty(UserInput))
            {
                CustomerName = order.CustomerName;
            }
            else
            {
                CustomerName = UserInput;
            }
            return CustomerName;
        }

        public static string GetEditState(string prompt, Order order)
        {
            Console.WriteLine(prompt);
            string UserInput = Console.ReadLine();
            string StateName = "";
            
            if (string.IsNullOrEmpty(UserInput))
            {
                StateName = order.State.StateName;

            }
            else
            {
                StateName = UserInput;
                order.State.StateName = StateName;
            }
            return StateName;
        }

        public static string GetEditProduct(string prompt, Order order)
        {
            Console.WriteLine(prompt);
            string UserInput = Console.ReadLine();
            string ProductType;
            
            if (string.IsNullOrEmpty(UserInput))
            {
                ProductType = order.Product.ProductType;
            }
            else
            {
                ProductType = UserInput;
                order.Product.ProductType = ProductType;
            }
            return ProductType;
        }

        public static decimal GetEditArea(string prompt, Order order)
        {
            Console.WriteLine(prompt);
            string UserInput = Console.ReadLine();
            int translatedNumber;
            decimal OrderArea;
            int.TryParse(UserInput, out translatedNumber);
            if (string.IsNullOrEmpty(UserInput))
            {
                OrderArea = order.Area;
            }
            else
            {
                OrderArea = translatedNumber;
            }
            return OrderArea;
        }

        public static State GetRequiredStateFromUser(string prompt)
        {
            Console.Write(prompt);
            string userInput = Console.ReadLine();
            State state = new State();
            
            state.StateName = userInput;

            return state;
        }

        public static Product GetRequiredProductFromUser(string prompt)
        {
            Console.Write(prompt);
            string userInput = Console.ReadLine();
            Product product = new Product();

            product.ProductType = userInput;

            return product;
        }
        

        }
    }

