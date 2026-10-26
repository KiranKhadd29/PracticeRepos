using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    //Here are the FizzBuzz rules that you need to implement in your code project:
        //1. Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
        //2. When the current value is divisible by 3, print the term Fizz next to the number.
        //3. When the current value is divisible by 5, print the term Buzz next to the number.
        //4. When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
    class FizzBuzz
    {
        public static void Main()
        {
            for (int i=1; i<=100; i++)
            {
                bool divByThree = i%3 == 0;
                bool divByFive = i%5 == 0;

                if (divByThree && divByFive)
                    Console.WriteLine(i + " FizzBuzz");
                else if (divByThree)
                    Console.WriteLine(i +" -Fizz");
                else if (divByFive)
                    Console.WriteLine(i + " -Buzz");
                else
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
