using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class Board
    {
        public Board()
        {
            string horizontal = ("-----------");
            string vertical = (" | ");
            char[] spaces = new char[9];

            for (int i = 1; i <= 9; i += 3)
            {
                Console.Write(" ");
                Console.Write(i);
                Console.Write(vertical);
                Console.Write(i + 1);
                Console.Write(vertical);
                Console.Write(i + 2);
                Console.WriteLine();

                if (i < 7) { Console.WriteLine(horizontal); }



            }

        }
    }
}
