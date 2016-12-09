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
    public class EditOrderWorkflow
    {
        public void Execute()
        {
            DateTime date = new DateTime();
            List<Order> resultsList = new List<Order>();
            OrderManager manager = new OrderManager();
            Order editedOrder = new Order();
            Console.Clear();
            Console.WriteLine("Edit Order Data");
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


            int selection = ConsoleIO.GetRequiredIntFromUser("Please enter the number of the order you'd like to edit: ");
        var selectedOrder = from o in resultsList
                            where o.OrderNumber == selection
                            select o;
            Order editOrder = selectedOrder.FirstOrDefault();
            editedOrder.State = new State();
            editedOrder.Product = new Product();
            Console.WriteLine("Press enter to keep the existing value.", editOrder);
            editedOrder.OrderDate = editOrder.OrderDate;
            editedOrder.CustomerName = ConsoleIO.GetEditStringName($"Enter the new customer name ({editOrder.CustomerName}):", editOrder);
            editedOrder.State.StateName = ConsoleIO.GetEditState($"Enter the new state ({editOrder.State.StateName}):", editOrder);
            editedOrder.Product.ProductType = ConsoleIO.GetEditProduct($"Enter the new product to be ordered ({editOrder.Product.ProductType}):", editOrder);
            editedOrder.Area = ConsoleIO.GetEditArea($"Enter the new square footage to be covered ({editOrder.Area}):", editOrder);
            editedOrder.OrderNumber = editOrder.OrderNumber;

            editedOrder.State = manager.GetStateInfo(editedOrder.State.StateName);
            editedOrder.Product = manager.GetProductInfo(editedOrder.Product.ProductType);
            editedOrder.Tax = editedOrder.State.TaxRate*editedOrder.Area*editedOrder.Product.CostPerSquareFoot*.01M;
            editedOrder.MaterialCost = editedOrder.Area * editedOrder.Product.CostPerSquareFoot;
            editedOrder.LaborCost = editedOrder.Area * editedOrder.Product.LaborPerSquareFoot;
            editedOrder.Total = editedOrder.Tax + editedOrder.MaterialCost + editedOrder.LaborCost;



            manager.EditOrder(date, editOrder, editedOrder);
            Console.WriteLine("Order edited.");
            Console.ReadLine();
            Console.Clear();
            MainMenu.Main();

        }


    }
}
