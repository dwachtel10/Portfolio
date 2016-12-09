using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    
    class GameWorkFlow
    {
        //Player p1 = new Player();
        // Player p2 = new Player();
        private static Player[] players;
        
        
        

        public static void Main()
        {

            var game = new GameWorkFlow();
           
            do
            {
                players = new Player[2];
                ConsoleIO.Clear();
                ConsoleIO.Display("Welcome to Tic-Tac-Toe!");
                Player player1 = new Player(ConsoleIO.PromptMsg("Player 1, please enter your name"), "X");
                ConsoleIO.Display($"Hello, {player1.Name}!  You will be X.");
                Player player2 = new Player(ConsoleIO.PromptMsg("Player 2, please enter your name"), "O");
                ConsoleIO.Display($"Hello, {player2.Name}!  You will be O.");
                ConsoleIO.Display("Press any key to start!");
                Console.ReadKey();
                players[0] = player1;
                players[1] = player2;
                Board Board1 = new Board();
                Player currentPlayer;
                ConsoleIO.Clear();
                ConsoleIO.Display(Board1.printBoard());
                for (int i = 1; i < 10; i++)
                {
                    if (i % 2 != 0)
                    {
                        ConsoleIO.Display($"{player1.Name}, it is your turn.  Please pick a space.");
                        currentPlayer = player1;
                    }
                    else
                    {
                        ConsoleIO.Display($"{player2.Name}, it is your turn.  Please pick a space.");
                        currentPlayer = player2;
                    }


                    PlaceResult result = PlaceResult.Invalid;
                    do
                    {
                        ConsoleIO.Clear();
                        ConsoleIO.Display(Board1.printBoard());
                        int slot = ConsoleIO.PromptInt($"{currentPlayer.Name}, please pick a space!");
                        slot--;
                        result = Board1.PlaceMark(slot, currentPlayer.Mark);
                        if (result == PlaceResult.Win || result == PlaceResult.Tie)
                        {
                            break;
                        }

                    }
                    while (result != PlaceResult.Ok);

                    if (result == PlaceResult.Win)
                    {
                        ConsoleIO.Display($"{currentPlayer.Name} is the Winner!");
                        break;
                    }
                    if (result == PlaceResult.Tie)
                    {
                        ConsoleIO.Display("Tough luck!  It's a tie!");
                        break;
                    }
                }
            } while (ConsoleIO.PromptMsg("Would you like to play again?  Y/N").ToUpper() == "Y");           
        }
    }
}
