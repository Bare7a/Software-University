namespace _01.Point3D
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var point = new Point3D(15.6, 18.2, 3);
            Console.WriteLine(point);

            Console.WriteLine(Point3D.StartingPoint);
        }
    }
}
