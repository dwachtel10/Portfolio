using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Flooring.BLL;
using Flooring.Data;
using Flooring.Models;
using Flooring.Models.Responses;

namespace Flooring.UI.Workflows
{
    public class ViewOrderWorkflow
    {
        public void Execute()
        {
            OrderManager manager = OrderManagerFactory.Create();

            Console.Clear();
            bool validResponse = false;
            Console.WriteLine("View order details");
            Console.WriteLine(ConsoleIO.HorizontalLine);
            int numberResult;
            int dateResult;
            Console.WriteLine("Enter the date of the order (MMDDYYYY): ");
            string dateInput = Console.ReadLine();
            int.TryParse(dateInput, out dateResult);
            //List<Order> dateOrders = new List<Order>();

            //OrderLookupResponse dateResponse = manager.LookupOrder(())
            OrderLookupResponse response = manager.LookupOrder(dateResult);

            while
            (validResponse == false)
            {
                if (response.Success)
                {
                    Console.WriteLine("Here are the orders from that date.");
                    Console.WriteLine();
                    Console.ReadLine();
                    
                    //dateOrders.Add(response.Order);
                    Console.WriteLine(ConsoleIO.HorizontalLine);

                    Console.WriteLine("Enter Order Number:  ");
                    string numberInput = Console.ReadLine();
                    int.TryParse(numberInput, out numberResult);
                    Console.Clear();
                    ConsoleIO.FullOrderDetails(response.Order);
                    Console.ReadLine();
                    validResponse = true;



                }
                else
                {
                    Console.WriteLine("Invalid number.  Please enter an order number to look up (1, 2, etc.)");
                    break;


                }

            }
        }
    }
    }

