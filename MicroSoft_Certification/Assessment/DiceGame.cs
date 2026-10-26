using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class DiceGame
    {
        static int roll1 = 0;
        static int roll2 = 0;
        static int roll3 = 0;
        static int total = 0;
        public static void Main()
        {
            // Roll the dice
            Random dice = new Random();
            roll1 = dice.Next(1, 7);
            roll2 = dice.Next(1, 7);
            roll3 = dice.Next(1, 7);
            total = roll1 + roll2 + roll3;

            // Display the roll and total
            Console.WriteLine($"Lets roll the dice \n roll1 :{roll1} \n roll2 :{roll2}\n roll3 :{roll3}\n In total : {total}");

            // Award a bonus for doubles or triples
            Bonus();

            // Display the final result
            Awards();

            Console.ReadLine();
        }

        public static void Bonus()
        {
            if ((roll1==roll2) || (roll2==roll3) || (roll1==roll3) )
            {
                if ((roll1==roll2) && (roll2==roll3))
                {
                    Console.WriteLine("You rolled triples! +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles! +2 bonus to total!");
                    total += 2;
                }
            }

        }

        public static void Awards()
        {
            if (total >= 16)
            {
                Console.WriteLine("You win a new car!");
            }
            else if (total >= 10)
            {
                Console.WriteLine("You win a new laptop!");
            }
            else if (total == 7)
            {
                Console.WriteLine("You win a trip for two!");
            }
            else
            {
                Console.WriteLine("You win a kitten!");
            }
        }
    }
}
