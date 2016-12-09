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
            Console.WriteLine($"{order.Date}");
            Console.WriteLine($"{order.OrderNumber}");

        }
    }
}
