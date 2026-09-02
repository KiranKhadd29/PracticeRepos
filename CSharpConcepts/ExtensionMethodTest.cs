using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    //This is sealed class and will not modified the code
    class ExtensionMethodTest
    {
        public void Test1()
        {
            Console.WriteLine("Method 1 excecuted!");
        }

        public void Test2()
        {
            Console.WriteLine("Method 2 excecuted!");
        }

        //public static void Main()
        //{
        //    ExtensionMethodTest ext = new ExtensionMethodTest();
        //    ext.Test1();
        //    ext.Test1();
        //}
    }
}
