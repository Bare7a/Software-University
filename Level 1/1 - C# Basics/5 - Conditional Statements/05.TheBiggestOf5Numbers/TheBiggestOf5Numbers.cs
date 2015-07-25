using System;

namespace TheBiggestOf5Numbers
{
    class TheBiggestOf5Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Input third number: ");
            double num3 = double.Parse(Console.ReadLine());
            Console.Write("Input fourth number: ");
            double num4 = double.Parse(Console.ReadLine());
            Console.Write("Input fifth number: ");
            double num5 = double.Parse(Console.ReadLine());
            double max = num1;
            if (max < num2)
            {
                max = num2;
            }
            if (max < num3)
            {
                max = num3;
            }
            if (max < num4)
            {
                max = num4;
            }
            if (max < num5)
            {
                max = num5;
            }
            Console.WriteLine("Max: " + max);
        }
    }
}
