using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abba
{
    class Program
    {
        static void Main(string[] args)
        {
            Program scramble = new Program();

            scramble.Abba("Hi", "Bye");
            scramble.Abba("Yo", "Alice");
            scramble.Abba("What", "Up");
            
            Console.ReadLine();
        }
        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }
    }
}
