using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.BLL;
using Flooring.Models;
using Flooring.Models.Responses;

namespace Flooring.UI.Workflows
{
    public class RemoveOrderWorkflow
    {
        public void Execute()
        {
            
            DateTime date = new DateTime();
            OrderManager manager = new OrderManager();
            List<Order> resultsList = new List<Order>();
            Console.Clear();
            Console.WriteLine("Delete Order Data");
            Console.WriteLine(ConsoleIO.HorizontalLine);
            Console.WriteLine("Enter the date of the order: ");
            string prompt = Console.ReadLine();
            

            date = ConsoleIO.GetRequiredDateTimeFromUser(prompt);

            ViewOrderResponses response = manager.ViewOrders(date);

            if (response.orders == null)
            {
                Console.WriteLine("No orders found for that date.");
                Console.WriteLine("Press any key to return to the Main Menu.");
                Console.ReadKey();
                Console.Clear();
                MainMenu.Main();
            }


            foreach (var order in
                response.orders)
            {

                ConsoleIO.DisplayOrderDetails(order);
                resultsList.Add(order);
                Console.ReadLine();

            }

            
            
           
             int selection = ConsoleIO.GetRequiredIntFromUser("Please enter the number of the order you'd like to delete: ");

            var selectedOrder = from o in resultsList
                where o.OrderNumber == selection
                select o;
            Order deleteOrder = selectedOrder.FirstOrDefault();

            




            string answer = ConsoleIO.GetYesNoAnswerFromuser($"Are you sure you want to delete #{deleteOrder.OrderNumber}? Enter Y for Yes or N for No.");

            if (answer == "Y")
            {
                Console.WriteLine("Order deleted. Returning to main menu.");
                Console.ReadLine();
                manager.RemoveOrder(date, deleteOrder);
                Console.Clear();
                
            }
            else
            {
                {
                    Console.WriteLine("Deletion cancelled.");
                    Console.WriteLine("Press any key to return to the main menu.");
                    Console.ReadKey();
                }
            }

            MainMenu.Main();

        }
    }
}
