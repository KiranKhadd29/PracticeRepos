using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeStudy
{
    class OperatorPractice
    {
        //Unary operator
        public void IncrementDecrementPrg ()
        {
            int x = 10;
            int y;
            y = x++ + ++x + x-- + --x;
           //y =10 + 12 + 12 + 10

            Console.WriteLine($"x = {x} , y= {y}");
        }

        public void TernaryOperator()
        {
            int num = 11;

            Console.WriteLine(num%2==0 ? $"{num} is Even number": $"{num} is Odd number");
        }
    }
}
