using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Welcome to coding world!");
            
            // Ask for the user's name
            Console.WriteLine("Whats your good name?");
            string name = Console.ReadLine();

            // Display a personalized greeting
            Console.WriteLine($"Hi,{name} nice to meet you!");
            //ex1();
            //ex2();
            //ex3();
            Console.ReadLine();
        }

        public static void ex1()
        {
            Console.WriteLine("Windows " + 7 + 4);
            Console.WriteLine($"Windows {1 + 1}");
            Console.Write("Windows " + 1 + 1);
        }

        public static void ex2()
        {
            int result = 3 + 1 * 5 / 2;
            Console.Write("result " + result);
        }

        public static void ex3()
        {
            Console.WriteLine(5 / 10);
        }
    }
}
