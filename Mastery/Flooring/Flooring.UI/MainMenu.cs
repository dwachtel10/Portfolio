using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Flooring.UI.Workflows;


namespace Flooring.UI
{
    public class MainMenu
    {
        public static void Main()
        {
            Console.WriteLine(ConsoleIO.HorizontalLine);
            Console.WriteLine("Flooring Order Management System");
            Console.WriteLine(ConsoleIO.HorizontalLine);
            Console.WriteLine("1. List Orders");
            Console.WriteLine("2. Add Order");
            Console.WriteLine("3. Edit Order");
            Console.WriteLine("4. Delete Order");
            Console.WriteLine("Q. Quit");
            Console.WriteLine(ConsoleIO.HorizontalLine);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Please enter your selection: ");
            

            bool validInput = false;
            while (validInput == false)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ViewOrderWorkflow viewOrder = new ViewOrderWorkflow();
                        validInput = true;
                        viewOrder.Execute();
                        break;
                        
                    case "2":
                        AddOrderWorkflow addOrder = new AddOrderWorkflow();
                        validInput = true;
                        addOrder.Execute();
                        break;
                        
                    case "3":
                        EditOrderWorkflow editOrder = new EditOrderWorkflow();
                        validInput = true;
                        editOrder.Execute();
                        break;
                    case "4":
                        RemoveOrderWorkflow deleteOrder = new RemoveOrderWorkflow();
                        validInput = true;
                        deleteOrder.Execute();
                        break;
                        
                    case "Q":
                        return;
                    default:
                        Console.WriteLine("Invalid selection.  Please enter one of the above options.");
                        break;
                }

                
            }

        }

    }
}
