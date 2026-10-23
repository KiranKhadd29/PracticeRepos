using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ThreadingConcept
{
    class ThreadPerformance
    {
        public static void Main()
        {
            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();

            Thread t1 = new Thread(IncrementCounter1);
            Thread t2 = new Thread(IncrementCounter2);

            sw1.Start();
            IncrementCounter1();
            IncrementCounter2();
            sw1.Stop();
            Console.WriteLine("Time took by normal thread :" + sw1.ElapsedMilliseconds);


            sw2.Start();
            t1.Start();
            t2.Start();
            sw2.Stop();
            t1.Join();
            t2.Join();
            Console.WriteLine("Time took by multi thread :" + sw2.ElapsedMilliseconds);
            Console.ReadLine();
        }

        public static void IncrementCounter1()
        {
            long cnt = 0;
            for (long i = 1; i <= 10000000000; i++)
                cnt++;
            Console.WriteLine("Counter 1 : " + cnt);
        }

        public static void IncrementCounter2()
        {
            long cnt = 0;
            for (int i = 1; i <= 100000000; i++)
                cnt++;
            Console.WriteLine("Counter 2 : " + cnt);
        }
    }
}
