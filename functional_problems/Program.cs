using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number3:");
            int c = Convert.ToInt32(Console.ReadLine());
            
            if ((a > b) && (a > c))
                Console.WriteLine("a = {0} is the largest number", a);

            else if (b > c)
                Console.WriteLine("b = {0} is the largest number", b);

            else
                Console.WriteLine("c = {0} is the largest number", c);
        }
    }
}