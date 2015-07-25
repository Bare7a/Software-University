using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.Write("Input width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Input height: ");
            double height = double.Parse(Console.ReadLine());
            double perimeter = (2*height)+(2*width);
            double area = height * width;
            Console.WriteLine("Perimeter: {0}, Area {1}",perimeter, area);
        }
    }
}
