using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class ExtensionMethodRun
    {
        public static void Main()
        {
            ExtensionMethodTest ext = new ExtensionMethodTest();
            //Here ext method gets called.
            ext.Test2();
            ext.Test3();
            ext.Test4(1);

            int factNum = 10;
            Console.WriteLine($"Factorial of {factNum} = " + factNum.Factorial());
            

            string hi = "HeLLo hOW aRE YOU";
            string res = hi.ToProper();
            Console.WriteLine("Proper result of {0} is {1}", hi, res);
            Console.ReadLine();
        }
        
    }
}
