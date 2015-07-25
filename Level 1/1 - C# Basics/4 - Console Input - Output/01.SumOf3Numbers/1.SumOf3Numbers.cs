using System;

namespace SumOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Input third number: ");
            double num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} + {2} = {3}",num1,num2,num3,num1+num2+num3);
        }
    }
}
