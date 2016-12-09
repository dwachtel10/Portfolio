using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class ConsoleIO
    {
        public static void Display(string msg)
        {
            Console.WriteLine(msg);
        }
        public static string PromptMsg(string msg)
        {
            Display(msg);
            return Console.ReadLine();
        }
        public static void Clear()
        {
            Console.Clear();
        }
        public static int PromptInt(string msg)
        {
            bool isValid = false;
            int result = -1;
            do
            {
                string input = PromptMsg(msg);
                isValid = int.TryParse(input, out result);
                
            } while (!isValid);

            return result;
        }
    }
}
