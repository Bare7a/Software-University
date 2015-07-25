﻿using System;

namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input c: ");
            double c = double.Parse(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                Console.WriteLine("No real roots.");
            }
            else if (d == 0)
            {
                Console.WriteLine("x1 = x2 = {0}", -b / (2 * a));
            }
            else
            {
                Console.WriteLine("x1 = {0}, x2 = {1}",(-b - Math.Sqrt(d)) / (2 * a), (-b + Math.Sqrt(d)) / (2 * a));
            }
        }
    }
}
