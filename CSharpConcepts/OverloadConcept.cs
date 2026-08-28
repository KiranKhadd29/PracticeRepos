using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class OverloadConcept
    {
        internal void Test()
        {
            Console.WriteLine("Method 1 excuted");
        }
        internal void Test(int i)
        {
            Console.WriteLine("Method 2 excuted with para :" + i);
        }
        internal void Test(string s)
        {
            Console.WriteLine("Method 3 excuted with para : " + s);
        }
        internal void Test(int i, string s)
        {
            Console.WriteLine("Method 4 excuted with paras : " + i + " " + s);
        }
        
        public static void Main()
        {
            OverloadConcept overload = new OverloadConcept();
            Console.WriteLine("Method Overloading Concept");
            overload.Test();
            overload.Test(10);
            overload.Test("Hello");
            overload.Test(10, "Testing");
            Console.ReadKey();
        }
    }
}
