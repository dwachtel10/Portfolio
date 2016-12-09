using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Models;

namespace Flooring.UI
{
    public class ConsoleIO
    {
       
        public const string HorizontalLine = "==========================================================";

        public static void DisplayOrderDetails(Order order)
        {
            Console.WriteLine($"{order.OrderDate}");
            Console.WriteLine($"{order.OrderNumber}");
            Console.WriteLine($"{order.CustomerName}");

        }

        public static void FullOrderDetails(Order order)
        {
            Console.WriteLine($"{order.OrderDate}");
            Console.WriteLine($"{order.OrderNumber}");
            Console.WriteLine($"{order.CustomerName}");
            Console.WriteLine($"{order.ProductType}");
            Console.WriteLine($"{order.Total}");
        }
    }
}
