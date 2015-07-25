using System;

namespace Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input h: ");
            double h = double.Parse(Console.ReadLine());
            double area = ((a + b) / 2) * h;
            Console.WriteLine("Area: {0}",area);
        }
    }
}
