using System;

namespace CircleAreaAndPerimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input r: ");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Radius {0:0.00} | Area: {1:0.00} | Perimeter {2:0.00}",r,r*r*3.14159,r*3.14159*2);
        }
    }
}
