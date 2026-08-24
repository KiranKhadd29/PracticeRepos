using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class ExplicitConstructor
    {
        int num;
        internal ExplicitConstructor()
        {
            Console.WriteLine("Constuctor called!!!");
            Console.WriteLine("Value of num:" + num);
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
    }
}
