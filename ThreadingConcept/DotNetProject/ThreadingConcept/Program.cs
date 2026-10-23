using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingConcept
{
    class Program
    {
        static void Test()
        {
            for (int i=1; i<=100; i++)
            {
                Console.WriteLine("Test :" + i);
            }
        }
        static void Main(string[] args)
        {
            //both will work same operation
            //explicitly called delegate
            //instatiate - way 1
            ThreadStart obj = new ThreadStart(Test);
            //instatiate - way 2
            ThreadStart obj2 = Test;
            //instatiate - way 3
            ThreadStart obj3 = delegate () 
            { 
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine("Test :" + i);
                }
            }; //Ananomus method
            //instatiate - way 4
            ThreadStart obj4 = () => Test(); // lambda expression
            //explicitly
            Thread t1 = new Thread(obj);
            //Implicite call
            Thread t2 = new Thread(Test);
            Console.WriteLine("Using Delegate function");
            t1.Start();
            Thread.Sleep(5000);
            Console.WriteLine("Using Directly Thread fun");
            t2.Start();
            Console.ReadLine();
        }
    }
}
