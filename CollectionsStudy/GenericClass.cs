using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsStudy
{
    class GenericClass<T>
    {
        public void Add(T item1, T item2)
        {
            dynamic d1 = item1;
            dynamic d2 = item2;
            Console.WriteLine("Addition res : " + (d1 + d2));
        }

        public void Sub(T item1, T item2)
        {
            dynamic d1 = item1;
            dynamic d2 = item2;
            Console.WriteLine("Substaction res : " + (d1 - d2));
        }

        public void Mul(T item1, T item2)
        {
            dynamic d1 = item1;
            dynamic d2 = item2;
            Console.WriteLine("Multiplication res : " + (d1 * d2));
        }

        public void Div(T item1, T item2)
        {
            dynamic d1 = item1;
            dynamic d2 = item2;
            Console.WriteLine("Division res : " + (d1 / d2));
        }
    }

        class RunMyMainMethod
        {
            public static void Main()
            {
                GenericClass<int> gen = new GenericClass<int>();
                gen.Add(10, 20);
                gen.Sub(20, 20);
                gen.Mul(13, 8);
                gen.Div(5, 0);

                Console.ReadLine();
            }
        }
}
