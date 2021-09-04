using System;

class POWER
{	public static void Main()
	{
		int value = 2;
		int b = Convert.ToInt32 (Console.ReadLine());
		for (int power = 0; power <= b; power++ )
		{
			Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0}");
	
		}
	}
}
