using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Flooring.BLL;
using Flooring.Data.Factory;
using Flooring.Data.TestRepos;
using Flooring.Models;
using Flooring.Models.Responses;
using NUnit.Framework;

namespace Flooring.UI.Workflows
{
    public class ViewOrderWorkflow
    {
        public void Execute()
        {
            OrderManager manager = new OrderManager();


            Console.Clear();
            DateTime date = new DateTime();
            int indexNumber;
            DateTime DateToCheck;
            bool validDate = false;
            bool validResponse = false;
            List<Order> resultsList = new List<Order>();
            Console.WriteLine("View Order Details");
            Console.WriteLine(ConsoleIO.HorizontalLine);


            Console.WriteLine("Enter the date of the order: ");
            string prompt = Console.ReadLine();


            date = ConsoleIO.GetRequiredDateTimeFromUser(prompt);



            ViewOrderResponses response = manager.ViewOrders(date);
            //while (!validDate)

            if (response.orders == null)
            {
                Console.WriteLine("No orders found for that date.");
                Console.WriteLine("Press any key to return to the Main Menu.");
                ConsoleIO.ErrorLogging();
                Console.ReadKey();
                Console.Clear();
                MainMenu.Main();
            }

            

            foreach (var order in
                response.orders)
            {
                
                ConsoleIO.DisplayOrderDetails(order);
                Console.ReadLine();
                resultsList.Add(order);
                
            }

           

            Console.WriteLine("Please enter the number that corresponds to the order you'd like to see in more detail: ");
            string input = Console.ReadLine();
            
            
            
             while (validResponse == false)
            {
                 indexNumber = ConsoleIO.GetRequiredIntFromUser(input);
                if (indexNumber <= resultsList.Count) 
                {
                    ConsoleIO.FullOrderDetails(resultsList[indexNumber - 1]);
                    Console.ReadLine();
                    validResponse = true;
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Number outside of range of results.");
                    ConsoleIO.ErrorLogging();
                    Console.WriteLine("Please enter the number of the order you'd like to see in more detail: ");
                    input = Console.ReadLine();
                }
                

            }
             Console.Clear();
             MainMenu.Main();
        }
    }
}
