using System;

namespace PointInsideCircleAndOutsideOfRectangle
{
    class PointInsideCircleAndOutsideOfRectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Input x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Input y = ");
            double y = double.Parse(Console.ReadLine());

            bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5);
            bool isOutsideRectangle = !(((x >= -1) && (x <= 5)) && ((y >= -1 ) && (y <= 1)));

            if (isInCircle == true && isOutsideRectangle == true)
            {
                Console.WriteLine("The point is inside the circle and outside of the rectangle.");
            }
            else
            {
                Console.WriteLine("The point isn't inside the circle and outside of the rectangle.");
            }
        }
    }
}
