namespace _02.DistanceCalculator
{
    using System;
    using _01.Point3D;

    public static class DistanceCalculator
    {
        private const int Pow = 2;

        public static double Calculate3DPointDistance(Point3D pointA, Point3D pointB)
        {
            return Math.Sqrt(
                Math.Pow(pointB.AxisX - pointA.AxisX, Pow) +
                Math.Pow(pointB.AxisY - pointA.AxisY, Pow) +
                Math.Pow(pointB.AxisZ - pointA.AxisZ, Pow));
        }
    }
}