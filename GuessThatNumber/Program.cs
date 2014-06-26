using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I want to play a game human...");

            GuessThatNumber();

            Console.WriteLine("Test your luck again human?");
            string answer = Console.ReadLine();
            string lower = answer.ToLower();
            if (lower == "yes")
            {
                GuessThatNumber();
            }
            else
	        {
                Console.WriteLine("Shame on you meat bag");
	        }
    

            //keep the console open
            Console.ReadKey();
        }

        static void GuessThatNumber()
        {
            Console.WriteLine("I have a number...");
            
            //computer generates a random number between 1 and 100
            Random compGuess = new Random();
            int randomNum = compGuess.Next(1,101);
            //counts the amount of guesses you make starting with 0
            int count = 0;
            //converting human guess string to an integer
            int newInput = 0;

            Console.WriteLine("What is your guess human?");

            while (newInput != randomNum)
            {
                //reads the human guess
                string yourGuess = Console.ReadLine();
                //changes string to int
                int input = int.Parse(yourGuess);

                



                //seeing if yourGuess is less than the randomNum
                if (input < randomNum)
                {
                    //prints to the console to guess higher
                    Console.WriteLine("Guess higher minion.");
                    //adds 1 to the count
                    count++;
                }
                //if yourGuess is greater than randomNum
                else if (input > randomNum)
                {
                    //print out guess lower
                    Console.WriteLine("Guess lower minion.");
                    //add 1 to the count
                    count++;
                }

                else if (input == randomNum)
                {
                    //print out you are a winner
                    Console.WriteLine("You guessed it. It only took you " + (count + 1) + " guesses meat bag.");
                }
            }
        }
    }
}
