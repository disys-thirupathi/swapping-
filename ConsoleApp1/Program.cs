using System;

public class Class1
{
	public static void Main()
	{
		Console.WriteLine("num1");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("num2");
		int num2 = Convert.ToInt32(Console.ReadLine());
		num1 = num1 + num2;
		num2 = num1 - num2;
		num1 = num1 - num2;
		Console.WriteLine("num1 & num2 is " + num1 +" & " +num2);
	}
}