using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Input third number: ");
            double num3 = double.Parse(Console.ReadLine());
            if (num1 * num2 * num3 > 0)
            {
                Console.WriteLine("+");
            }
            else if (num1 * num2 * num3 < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
