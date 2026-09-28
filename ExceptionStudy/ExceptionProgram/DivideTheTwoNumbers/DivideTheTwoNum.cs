using System;

public class TestExeptionDivideByZero
{
	public static void Main()
	{
		Console.WriteLine("Enter number num1 = ");
		int num1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter number num2 = ");
		int num2 = int.Parse(Console.ReadLine());
		int res = num1/num2;
		Console.WriteLine("Result = " + res);
		Console.WriteLine("Programme successful!!!");
		
		
	}
}