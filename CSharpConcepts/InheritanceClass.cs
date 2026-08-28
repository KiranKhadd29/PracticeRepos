using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class InheritanceClass
    {
        internal InheritanceClass()
        {
            Console.WriteLine("Constructor Excecuted from Parent!!!");
        }

        internal InheritanceClass(string para)
        {
            Console.WriteLine("Para Constructor Excecuted from Parent!!!");
        }
        internal void Test1()
        {
            Console.WriteLine("Test1 Excecuted from Parent!!!");
        }

        internal void Test2()
        {
            Console.WriteLine("Test2 Excecuted from Parent!!!");
        }
    }
}
