namespace _02.DistanceCalculator
{
    using System;
    using _01.Point3D;

    public class Program
    {
        public static void Main(string[] args)
        {
            var pointA = new Point3D(-7, -4, 3);
            var pointB = new Point3D(17, 6, 2.5);

            // You can validate the result here: http://www.calculatorsoup.com/calculators/geometry-solids/distance-two-points.php
            Console.WriteLine($"{DistanceCalculator.Calculate3DPointDistance(pointA, pointB):F8}");
        }
    }
}