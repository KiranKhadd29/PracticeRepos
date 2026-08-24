using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeStudy
{
    internal class ConstructorExamples
    {
        internal int x = 1, y = 2;
        internal int Addition ()
        {
            int sum = x + y;
            Console.WriteLine(sum);
            return sum;
        }

        //Constructor defination
        internal ConstructorExamples()
        {
            x = 10;
            y = 20;
        }

        //Parametric Constructor defination
        internal ConstructorExamples(int num1, int num2)
        {
            this.x = num1;
            this.y = num2;
        }

        //copy Constructor defination
        internal ConstructorExamples(ConstructorExamples o)
        {
            this.x = o.x;
            this.y = o.y;
        }
    }
}
