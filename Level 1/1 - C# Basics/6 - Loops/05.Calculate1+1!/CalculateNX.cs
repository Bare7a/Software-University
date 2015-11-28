using System;

namespace CalculateNX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a positive number [n] higher or equal to 1: ");
            uint n = uint.Parse(Console.ReadLine());
            if (n >= 1)
            {
                float sum = 1.0F;
                Console.Write("Input a number for [x]: ");
                int x = int.Parse(Console.ReadLine());
                int fact=1;
                for (int i = 1; i <= n; i++)
                {
                    fact*=i;
                    sum += fact / (float)Math.Pow(x, i);
                }
                Console.WriteLine("{0:F5}",sum);
            }
            else
            {
                Console.WriteLine("The number must be equal or higher than 1!");
            }

        }
    }
}
