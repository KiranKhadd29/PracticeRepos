using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class Variables
    {
        static string x = "Static Variable";
        string y = "Non-Static Variable";
        const string c = "Constant Variable";
        readonly string r = "Readonly Variable";

        public static void Main()
        {
            //Non-Static and Readonly variable need to initialize
            Variables var = new Variables();
            Console.WriteLine(var.y);
            Console.WriteLine(var.r);
            //Static and Constant variable no need to initialize
            Console.WriteLine(c);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
