using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_sandbox
{
    class Misc_code
    {
        public static void Main()
        {
            //
            //this doesn't work yet, I'm just writing it out to plug in later.
            //I'm not good at putting things together yet, but I can see how things work before I put them together
            if (((spaces[1] = 'X' && ((spaces[2] = 'X' && spaces[3] = 'X') || (spaces[5] = 'X' && spaces[9] = 'X'))) || 
               ((spaces[4] = 'X' && ((spaces[5] = 'X' && spaces[6] = 'X') || (spaces[1] = 'X' && spaces[7] = 'X'))) ||
                ((spaces[7] = 'X' && ((spaces[8] = 'X' && spaces[9] = 'X') || (spaces[5] = 'X' && spaces[3] = 'x'))) ||
                (spaces[2] = 'X' && spaces[5] = 'X' && spaces[8] = 'X') || (spaces[3] = 'X' && spaces[6] = 'X' && spaces[9] = 'X')))))
            {
                player1 wins;
                
            }
            else if (((spaces[1] = 'O' && ((spaces[2] = 'O' && spaces[3] = 'O') || (spaces[5] = 'O' && spaces[9] = 'O'))) ||
               ((spaces[4] = 'O' && ((spaces[5] = 'O' && spaces[6] = 'O') || (spaces[1] = 'O' && spaces[7] = 'O'))) ||
                ((spaces[7] = 'O' && ((spaces[8] = 'O' && spaces[9] = 'O') || (spaces[5] = 'O' && spaces[3] = 'O'))) ||
                (spaces[2] = 'O' && spaces[5] = 'O' && spaces[8]= 'O') || (spaces[3] = 'O' && spaces[6] = 'O' && spaces[9] = 'O')))))
            {//Christ, what a mess this is.  At least I think I got everything.
             //checked on paper, these are all the winning combinations.  8 total?
                player2 wins;
            }
            else { tie; }

            prompt play again;
        //
        }
    }
}
