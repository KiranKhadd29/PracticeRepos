using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    abstract class AbstractParent
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }

        public abstract int Mul(int x, int y);
        public abstract int Div(int x, int y);
    }

    class AbstractChild : AbstractParent
    {
        public override int Mul(int x, int y)
        {
            return x*y;
        }

        public override int Div(int x, int y)
        {
            return x / y;
        }

        public static void Main()
        {
            AbstractChild abs = new AbstractChild();
            Console.WriteLine("Addition :" + abs.Add(2, 2));
            Console.WriteLine("Substarction :" + abs.Sub(2, 2));
            Console.WriteLine("Multiplication :" + abs.Mul(2, 2));
            Console.WriteLine("Division :" + abs.Div(2, 2));

            Console.ReadKey();
        }

    }
}
