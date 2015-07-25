using System;

namespace PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Input y: ");
            double y = double.Parse(Console.ReadLine());
            bool isInside = (x * x) + (y * y) <= (2 * 2);
            Console.WriteLine("For [{0},{1}] the cordinates are inside the circle: {2}",x,y,isInside);
        }
    }
}
