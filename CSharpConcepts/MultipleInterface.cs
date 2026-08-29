using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    interface iTest1
    {
        void Display();
        void Show();
    }

    interface iTest2
    {
        void Display();
        void Show();
    }
    class MultipleInterface : iTest1, iTest2
    {
        public void Display()
        {
            Console.WriteLine("Multiple Interface Inheritance Successful!!!");
        }

        void iTest1.Show()
        {
            Console.WriteLine("Interface 1's Show!!!");
        }

        void iTest2.Show()
        {
            Console.WriteLine("Interface 2's Show!!!");
        }

        public static void Main()
        {
            MultipleInterface mi = new MultipleInterface();
            mi.Display();

            iTest1 i1 = mi;
            iTest2 i2 = mi;

            i1.Show();
            i2.Show();


            Console.ReadKey();
        }
    }
}
