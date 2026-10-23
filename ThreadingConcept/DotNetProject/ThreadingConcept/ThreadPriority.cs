using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingConcept
{
    class ThreadPriority
    {
        static long num1, num2;
        public static void Main()
        {
            Console.WriteLine("Main Thread is started");

            Thread cnt1 = new Thread(IncrementCounter1);
            Thread cnt2 = new Thread(IncrementCounter2);

            cnt1.Start();
            cnt2.Start();

            cnt1.Priority = System.Threading.ThreadPriority.Highest;
            cnt2.Priority = System.Threading.ThreadPriority.Lowest;

            Thread.Sleep(10000);

            cnt1.Abort();
            cnt2.Abort();

            cnt1.Join();
            cnt2.Join();

            Console.WriteLine("Counter1 :" + num1);
            Console.WriteLine("Counter1 :" + num2);

            Console.WriteLine("Main Thread is ended");
            Console.ReadLine();
        }

        public static void IncrementCounter1()
        {
            while (true)
                num1 += 1;
        }

        public static void IncrementCounter2()
        {
            while (true)
                num2 += 1;
        }
    }
}
