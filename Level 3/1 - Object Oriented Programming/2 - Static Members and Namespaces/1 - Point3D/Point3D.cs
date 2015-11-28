namespace _01.Point3D
{
    public class Point3D
    {
        private static readonly Point3D StartingPointCoordinates;

        static Point3D()
        {
            StartingPointCoordinates = new Point3D(0, 0, 0);
        }

        public Point3D(double axisX, double axisY, double axisZ)
        {
            this.AxisX = axisX;
            this.AxisY = axisY;
            this.AxisZ = axisZ;
        }

        // XML-Serializable class needs a parameterless constructor
        private Point3D()
        {
        }

        public static Point3D StartingPoint
        {
            get
            {
                return Point3D.StartingPointCoordinates;
            }
        }

        public double AxisX { get; set; }

        public double AxisY { get; set; }

        public double AxisZ { get; set; }

        public override string ToString()
        {
            return $"Point: {{x={this.AxisX}, y={this.AxisY}, z={this.AxisZ}}}";
        }
    }
}
