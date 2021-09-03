using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            double per1;
            double per2;
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            { 
                int toss = random.Next(0, 2);
                if (toss == 0)
                {
                     a += 1;
                }
                else if(toss == 1)
                {
                    b += 1;
                }
             }
            Console.WriteLine("heads:" + a);
            Console.WriteLine("tails:" + b);
            per1 = a * 100;
            per2 = b * 100;
            Console.WriteLine("heads percentage:" + per1/100);
            Console.WriteLine("tails percentage:" + per2/100);
        }
    }
}