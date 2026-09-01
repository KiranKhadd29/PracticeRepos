using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class LambaExpression
    {
        public static void Main()
        {
            Greetings obj = name =>
            {
                return "Hello," + name + " Good Morning!!!";
            };

            string str = obj.Invoke("Kiran");
            Console.WriteLine(str);

            Console.ReadKey();

        }
    }
}
