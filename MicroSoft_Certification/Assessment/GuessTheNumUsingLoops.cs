using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class GuessTheNumUsingLoops
    {
        public static void Main()
        {
            Random guess = new Random();
            int secretNumber = guess.Next(1, 21);
            Console.WriteLine("Try a guess 1 to 20!!!. You'll get only 5 chances");
            int guessTried = 0;
            bool hasWon = false;
            while (guessTried < 5)
            {
                guessTried++;
                Console.Write($"\nGuess #{guessTried}: ");
                int userGuess = int.Parse(Console.ReadLine());
                //string res = userGuess <= 20 == true ? "Yes, you're close" : "Ohho! Try smaller one.";
                //Console.WriteLine(res);
                if (userGuess == secretNumber)
                {
                    Console.WriteLine($"Correct! You got it in {guessTried} guesses. You won 1 Lakhs rupees!!!");
                    hasWon = true;
                    break;
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Too low.");
                }
                else
                {
                    Console.WriteLine("Too high.");
                } 
            }

            // Announce the result
            if (!hasWon)
            {
                Console.WriteLine($"\nOut of guesses! The number was {secretNumber}.");
                Console.WriteLine("Better luck next time!!!");
            }

            Console.ReadLine();
        }
    }
}
