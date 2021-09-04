using System;

namespace prime
{
	public class FACTOR
	{
		public static void primeFactors(int num)
		{
			for (int i = 2; i*i <= num; i++) 
			{
				while (num % i == 0)
				{
					Console.WriteLine(i);
					num = (num / i);
				}
			}
		}
		public static void Main()
		{
			Console.WriteLine("enter number");
			int num = Convert.ToInt32(Console.ReadLine());
			primeFactors(num);
		}

	}
}