using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsStudy
{
    class GenericMethod
    {
        public bool Compare<T>(T item1, T item2)
        {
            if (item1.Equals(item2))
                return true;
            return false;
        }
        public static void Main()
        {
            GenericMethod gen = new GenericMethod();
            bool intRes = gen.Compare<int>(10, 20);
            Console.WriteLine("Int Res :" + intRes);
            bool stringRes = gen.Compare<string>("Kiran", "Kiran");
            Console.WriteLine("String Res :" + stringRes);
            Console.ReadLine();
        }
    }
}
