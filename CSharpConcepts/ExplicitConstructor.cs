using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class ExplicitConstructor
    {
        int num = 1;
        static int num2 = 55;

        internal ExplicitConstructor()
        {
            Console.WriteLine("Constuctor called!!!");
            Console.WriteLine("Value of num:" + num);
            Console.WriteLine("Value of num:" + num2);
        }

        internal ExplicitConstructor(int numb)
        {
            this.num = numb;
            Console.WriteLine("Para Constuctor called!!!");
            Console.WriteLine(numb);
        }

        internal ExplicitConstructor(ExplicitConstructor obj)
        {
            this.num = obj.num;
            Console.WriteLine("Copy Constuctor called!!!");
            Console.WriteLine(obj.num);
        }

        static ExplicitConstructor()
        {
            Console.WriteLine("static Constuctor called!!!");
            //Console.WriteLine("Value of num:" + num);
            Console.WriteLine("Value of num:" + num2);
        }
    }
}
