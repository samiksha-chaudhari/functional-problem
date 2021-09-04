using System;
class HARMONIC
{

	static float sum(int n)
	{
		double i, s = 0.0;

		for (i = 1; i <= n; i++)
			s = s + 1 / i;

		return (float)s;
	}
	public static void Main()
	{
		Console.WriteLine("enter number:");
		int n = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Sum is "
						+ sum(n));
	}
}
