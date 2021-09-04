using System;

class POWER
{	public static void Main()
	{
		int value = 2;
		for (int power = 0; power <= 32; power++ ){
			Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})");
		Console.WriteLine("ab");
		}
	}
}
