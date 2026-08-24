using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeStudy
{
    class AdditionProgram
    {
        public void AdditionWithoutPlusSign()
        {
            Console.WriteLine("Enter num1 = ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2 = ");
            int num2 = int.Parse(Console.ReadLine());

            while (num2 != 0)
            {
                int carry = num1 & num2;
                num1 = num1 ^ num2;
                num2 = carry << 1;
            }

            Console.WriteLine($"Addition of numbers => {num1} ");
        }
    }
}
