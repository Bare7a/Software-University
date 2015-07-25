using System;

namespace ExchangeIfGrater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double num2 = double.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                double num3 = num1;
                num1 = num2;
                num2 = num3;
            }
            Console.WriteLine("{0} {1}",num1,num2);
        }
    }
}
