using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Interfaces;

namespace _01.Shapes.Models
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius cannot be a non-positive number!");
                }
                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public double CalucaltePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        public override string ToString()
        {
            return String.Format("Figure: {0} | Area = {1}, Perimeter = {2}", GetType().Name, Math.Round(CalculateArea(), 2), Math.Round(CalucaltePerimeter(), 2));
        }
    }
}
