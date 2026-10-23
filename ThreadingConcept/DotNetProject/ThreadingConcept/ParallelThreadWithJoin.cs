using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingConcept
{
    class ParallelThreadWithJoin
    {
		public static void Main()
		{
			Thread t = Thread.CurrentThread;
			t.Name = "Main Thread";

			Console.WriteLine(Thread.CurrentThread.Name + " is started");
			Thread t1 = new Thread(Test1);
			Thread t2 = new Thread(Test2);
			Thread t3 = new Thread(Test3);

			t1.Start();
			t2.Start();
			t3.Start();
			// Main Thread is calling Join(its like they are treated as child)
			t1.Join();
			t2.Join();
			t3.Join();

			Console.WriteLine(Thread.CurrentThread.Name + " is Ended");
			Console.ReadLine();
		}

		static void Test1()
		{
			for (int i = 1; i <= 50; i++)
			{
				Console.WriteLine("Test1 : " + i);
			}
			Console.WriteLine("Test1 is Ended");
		}

		static void Test2()
		{
			for (int i = 1; i <= 50; i++)
			{
				Console.WriteLine("Test2 : " + i);
				if (i == 20)
				{
					Console.WriteLine("Test2 is slept for 5 sec");
					Thread.Sleep(5000);
					Console.WriteLine("Test2 is woke up now");
				}
			}
			Console.WriteLine("Test2 is Ended");
		}

		static void Test3()
		{
			for (int i = 1; i < 100; i++)
			{
				Console.WriteLine("Test3 : " + i);
			}
			Console.WriteLine("Test3 is Ended");
		}
	}
}
