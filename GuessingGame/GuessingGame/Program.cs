using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Welcome to the Guessing Game!  Please enter your name!");
            string name = Console.ReadLine(); //generates input form
            // Console.WriteLine(name); test to make sure we got the name
            
            bool playAgain = false;
            do
            {
                Program start = new Program(); //this is needed to actually execute the program
                start.PlayGame(name);
                
                Console.WriteLine("Do you want to play again? Y/N");
                string response = Console.ReadLine();
                switch (response.ToUpper())
                {
                    case "Y":
                    case "YES":
                        playAgain = true;
                        break;
                    default:
                        playAgain = false;
                        break;
                }
            }
            while (playAgain);
        }


        public void PlayGame(string name)
        {
            
            Random rndm = new Random(); //pseudo-random number generator
            int targetNumber = rndm.Next(1, 21);
            


            bool isValid = false;
            int timesGuessed = 0;
            do
            {


                Console.WriteLine($"Enter a number between 1 and 20, {name}!  To quit, enter Q");
                string input = Console.ReadLine();
                //Console.WriteLine(input);
                int numberGuessed;
                isValid = int.TryParse(input, out numberGuessed);
                
                if (isValid) //we have a number
                {
                    timesGuessed++;
                    if (!(numberGuessed <= 20 && numberGuessed >= 1))
                    {
                        Console.WriteLine("Try again!");
                        isValid = false;
                        
                    }
                    else
                    {
                        if (numberGuessed == targetNumber)
                        {
                            Console.WriteLine($"You win, {name}!");
                            Console.WriteLine($"You guessed {timesGuessed} times.");
                            if (timesGuessed == 1)
                            { Console.WriteLine($"Wow,{name}, you got it on your first try!"); }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Oops, that's not it!  Try again!");
                            isValid = false;
                            
                        }
                    }

                }

                else //did they type Q?
                {
                    if (input.ToUpper() == "Q")
                    {
                        return;
                    }

                    Console.WriteLine("I said a NUMBER.");
                }
            } while (!isValid);

            

            
        }

    }
}
