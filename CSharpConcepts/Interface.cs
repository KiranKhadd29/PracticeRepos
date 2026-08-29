using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    interface ITestInterface1
    {
        int Add(int a, int b);
    }

    interface ITestInterface2 : ITestInterface1
    {
        int Sub(int a, int b);
    }

    class InterfaceImplementation : ITestInterface2
    {
        public int Add (int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public static void Main()
        {
            InterfaceImplementation iface = new InterfaceImplementation();
            
            int add = iface.Add(1, 2);
            int sub = iface.Sub(1, 2);
            Console.WriteLine("Addition = " + add);
            Console.WriteLine("Substarction = " + sub);
            Console.ReadKey();
        }


    }
}
