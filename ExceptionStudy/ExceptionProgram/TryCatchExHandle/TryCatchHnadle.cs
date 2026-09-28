using System;

public class TestExeptionDivideByZero
{
	public static void Main()
	{
		try
		{
			Console.WriteLine("Enter number num1 = ");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter number num2 = ");
			int num2 = int.Parse(Console.ReadLine());
			if (num2 == 1) return;
			int res = num1/num2;
			Console.WriteLine("Result = " + res);
			Console.WriteLine("Programme successful!!!");
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
		finally
		{
			Console.WriteLine("finally block excecuted successful!!!");
		}
		Console.WriteLine("End of the Program.");
	}
}