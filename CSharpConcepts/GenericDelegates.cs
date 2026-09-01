using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class GenericDelegates
    {
        public static double AddNum1 (int x, float y, double z)
        {
            return x + y + z;
        }

        public static void AddNum2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }

        public static bool CheckLength(string s)
        {
            if (s.Length > 5)
                return true;
            return false;
        }
        public static void Main()
        {
            Func<int, float, double, double> obj1 = AddNum1;
            double test = obj1.Invoke(11, 22.22f, 333.333);
            Console.WriteLine("Using func<> => " + test);

            Action<int, float, double> obj2 = AddNum2;
            Console.WriteLine("Using Action<> => ");
            obj2.Invoke(1, 2f, 3);
            

            Predicate<string> obj3 = CheckLength;
            bool status = obj3.Invoke("Hiiiii");
            Console.WriteLine("Using Predicate<> => "+ status);


            Console.ReadLine();

        }
    }
}
