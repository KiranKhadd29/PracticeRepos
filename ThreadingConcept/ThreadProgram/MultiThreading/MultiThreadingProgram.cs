using System;
using System.Threading;

class MainThreadPrgm 
{
	public static void Main()
	{
		Thread t = Thread.CurrentThread;
		t.Name  = "Main Thread";
		
		Console.WriteLine(Thread.CurrentThread.Name + " is started");
		Thread t1 = new Thread(Test1);
		Thread t2 = new Thread(Test2);
		Thread t3 = new Thread(Test3);
		
		t1.Start();
		t2.Start();
		t3.Start();
		
		Console.WriteLine(Thread.CurrentThread.Name + " is Ended");
	}
	
	static void Test1()
	{
		for (int i=1; i<=50; i++)
		{
			Console.WriteLine("Test1 : " + i);
		}
		Console.WriteLine("Test1 is Ended");
	}
	
	static void Test2()
	{
		for (int i=1; i<=50; i++)
		{
			Console.WriteLine("Test2 : " + i);
			if (i==50)
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
		for (int i=1; i<100; i++)
		{
			Console.WriteLine("Test3 : " + i);
		}
		Console.WriteLine("Test3 is Ended");
	}
	
}