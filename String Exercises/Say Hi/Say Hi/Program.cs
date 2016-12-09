using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Say_Hi
{
    class Program
    {
        static void Main(string[] args)
        {
            Program greet = new Program();

            greet.SayHi("Bob");
            greet.SayHi("Alice");
            greet.SayHi("X");

            Console.ReadLine();
        }

        public string SayHi(string name)
        {

            return ("Hello " + name + "!");

            
        } 
    }
    }
