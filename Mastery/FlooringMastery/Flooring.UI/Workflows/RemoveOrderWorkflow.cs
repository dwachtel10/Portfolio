using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flooring.UI.Workflows
{
    public class RemoveOrderWorkflow
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Delete Order Data");
            Console.WriteLine(ConsoleIO.HorizontalLine);
            Console.WriteLine("Enter the date of the order (MMDDYYYY): ");
            string dateInput = Console.ReadLine();
        }
    }
}
