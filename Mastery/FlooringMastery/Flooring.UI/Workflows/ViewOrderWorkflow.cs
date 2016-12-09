using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.BLL;

namespace Flooring.UI.Workflows
{
    public class ViewOrderWorkflow
    {
        public void Execute()
        {
            OrderManager manager = OrderManagerFactory.Create();

            Console.Clear();
            Console.WriteLine("View order details");
            Console.WriteLine(ConsoleIO.HorizontalLine);
            Console.WriteLine("Enter the date of the order (MMDDYYYY): ");
            string dateInput = Console.ReadLine();
            //parse to integer
            //display orders for that date
            //OrderLookupResponse response =

            ////if (response.Success)
            //{
            //    DisplayOrderDetails(response.Order);
            //}
            //else
            //{
            //    {
                    
            //    }
            //}
        }
    }
}
