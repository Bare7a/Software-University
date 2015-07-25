using System;

namespace NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("The bigger number from  {0} and {1} is {2}",num1,num2,Math.Max(num1,num2));
        }
    }
}
