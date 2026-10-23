using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingConcept
{
    class paraThreading
    {
        static void Test (object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Test :" + i);
            }
        }
        static void Main(string[] args)
        {
            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);
            Thread t = new Thread(obj);
            t.Start(75);
        }
    }
}
