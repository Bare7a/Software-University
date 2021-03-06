﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Interfaces;

namespace _01.Shapes.Models
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be a non-positive number!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be a non-positive number!");
                } 
                this.width = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalucaltePerimeter();
        public override string ToString()
        {
            return String.Format("Figure: {0} | Area = {1}, Perimeter = {2}", GetType().Name, Math.Round(CalculateArea(), 2), Math.Round(CalucaltePerimeter(), 2));
        }
    }
}
