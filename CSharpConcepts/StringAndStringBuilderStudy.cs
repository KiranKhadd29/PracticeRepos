using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpConcepts
{
    class StringAndStringBuilderStudy
    {
        public static void Main()
        {
            // String are immutable
            string str = "I am immutable";
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (int i=0; i<100000; i++)
            {
                str = str + i;
            }
            sw1.Stop();
            // StringBuilder is mutable
            StringBuilder sb = new StringBuilder("I am immutable");
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();

            Console.WriteLine("Time take to execute string values in loop =>" + sw1.ElapsedMilliseconds);
            Console.WriteLine("Time take to execute String Builder values in loop =>" + sw2.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
