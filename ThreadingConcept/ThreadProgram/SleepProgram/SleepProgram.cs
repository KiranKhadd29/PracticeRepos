using System;
using System.Threading;

class MainThreadPrgm 
{
	public static void Main()
	{
		Thread t = Thread.CurrentThread;
		t.Name  = "Main Thread";
		
		Console.WriteLine("Current executing thread is : " + Thread.CurrentThread.Name);
		
		Test1();
		Test2();
		Test3();
	}
	
	static void Test1()
	{
		for (int i=1; i<=100; i++)
		{
			Console.WriteLine("Test1 : " + i);
		}
	}
	
	static void Test2()
	{
		for (int i=1; i<=100; i++)
		{
			Console.WriteLine("Test2 : " + i);
			if (i==50)
			{
				Console.WriteLine("Main thread is slept for 5 sec");
				Thread.Sleep(5000);
				Console.WriteLine("Main thread is woke up now");
			}
				
		}
	}
	
	static void Test3()
	{
		for (int i=1; i<=100; i++)
		{
			Console.WriteLine("Test3 : " + i);
		}
	}
	
}