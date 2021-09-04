using System;

namespace myApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter number1:");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter number2:");
			int num2 = Convert.ToInt32(Console.ReadLine());
			
			int temp = num1;
			num1 = num2;
			num2 = temp;

			Console.WriteLine("After swapping...");
			Console.WriteLine("num1 = {0}", num1);
			Console.WriteLine("num2 = {0}", num2);
		}
	}
}