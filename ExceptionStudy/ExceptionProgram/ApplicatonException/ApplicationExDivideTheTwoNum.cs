using System;

public class TestExeptionDivideByZero
{
	public class DivideByOddNum : ApplicationException
	{
		public override string Message { get {return "Attempted to divide by Odd number";} }
		
	}
	public static void Main()
	{
		Console.WriteLine("Enter number num1 = ");
		int num1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter number num2 = ");
		int num2 = int.Parse(Console.ReadLine());
		if (num2 % 2 > 0) 
		{
			//throw new ApplicationException("Divisor can not be odd number");
			throw new DivideByOddNum();
		}
		int res = num1/num2;
		Console.WriteLine("Result = " + res);
		Console.WriteLine("Programme successful!!!");
	}
}