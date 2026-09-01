using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public delegate string Greetings(string s);
    class AnonymousDelegate
    {
        public static void Main()
        {
            Greetings obj = delegate (string name)
            {
                return "Hello," + name + " Good Morning!!!";
            };

            string str = obj.Invoke("Kiran");
            Console.WriteLine(str);

            Console.ReadKey();

        }
    }
}
