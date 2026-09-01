using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public delegate void AddNum(int a, int b);
    public delegate string SayHello(string s);
    class DelegateStudy
    {
        public void AddNum(int a, int b)
        {
            Console.WriteLine( a + b);
        }

        public string SayHello(string s)
        {
            return (s);
        }

        public static void Main()
        {
            DelegateStudy deleg = new DelegateStudy();
            AddNum ad = new AddNum(deleg.AddNum);
            ad(1, 2);
            ad.Invoke(3, 4);
            Console.WriteLine();

            SayHello hi = new SayHello(deleg.SayHello);
            string name = hi("Kiran");
            string surName = hi.Invoke("Khadd");
            Console.WriteLine(name + " " + surName);

            Console.ReadKey();

        }
    }
}
