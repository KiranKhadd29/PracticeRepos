using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingConcept
{
    class ThreadLocking
    {
        public static void Main()
        {
            Console.Write("Main Thread is started\n");
            //Way 01
            Console.Write("Way 01\n");
            ThreadLocking obj = new ThreadLocking();
            obj.Display();
            obj.Display();
            obj.Display();

            //Way 02
            Console.Write("Way 02 - using locking\n");
            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("Main Thread is ended");
            Console.ReadLine();

        }

        public void Display()
        {
            lock(this)
            {
                Console.Write("[CSharp is an ");
                Thread.Sleep(2000);
                Console.WriteLine("Object Oriented language]");
            }
        }
    }
}
