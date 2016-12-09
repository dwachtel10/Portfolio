using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            List<int> factors = new List<int>();
            
            Console.WriteLine("Please enter the number you'd like to factor:");
            input = int.Parse(Console.ReadLine());

            Console.WriteLine($"The factors of {input} are");

            Console.ReadLine();
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    factors.Add(i);
                    Console.WriteLine(i);
                    
                }
                                
            }
            int total = (factors.Sum() - input);

            if (factors.Count == 2)
            { Console.WriteLine($"{input} is a prime number!"); }
            else
            {
                Console.WriteLine($"{input} is not a prime number.");
            }

            if (total == input)
            {
                Console.WriteLine($"Wow! {input} is a perfect number!");
            }
            else
            {
                Console.WriteLine($"{input} is not a perfect number.");
            }
            Console.ReadLine();
        }
        
    }
}
