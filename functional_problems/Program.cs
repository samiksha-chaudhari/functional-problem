using System;

namespace division
{
    class DIVISION
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dividend:");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor:");
            int divisor = Convert.ToInt32(Console.ReadLine());


            

            float quotient = dividend / divisor;
            float remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}