using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_board
{
    public class Board 
    {
        public static void Main()
        {
            string horizontal = ("-----------");
            string vertical= (" | ");
            char[] spaces = new char[9];

            for (int i = 1; i <= 9; i+=3)
            {
                Console.Write(" ");
                Console.Write(i);
                Console.Write(vertical);
                Console.Write(i+1);
                Console.Write(vertical);
                Console.Write(i+2);
                Console.WriteLine();

                if (i < 7) { Console.WriteLine(horizontal); }



            }
            Console.WriteLine("Pick a space");
            Console.ReadLine();

            
            
            //it populates a decent enough grid, but holy God is this inefficient
            //doesn't really matter, I guess.  Can I reference this in a different class/program/whatevertheHell?
            //Did I get the array right?  Where'd the 0 end up?  Does it matter?

        }
    }
}
