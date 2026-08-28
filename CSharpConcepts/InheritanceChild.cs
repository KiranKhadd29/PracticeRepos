using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class InheritanceChild:InheritanceClass
    {
        InheritanceChild() : base ("Test") {}
        void Test3()
        {
            Console.WriteLine("Test3 Excecuted from Child!!!");
        }
        public static void Main()
        {
            InheritanceChild child = new InheritanceChild();
            child.Test1();
            child.Test2();
            child.Test3();
            Console.ReadKey();
        }
        
    }
}
