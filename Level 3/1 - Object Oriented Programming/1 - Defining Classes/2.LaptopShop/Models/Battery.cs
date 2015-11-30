using System;

namespace _2___Laptop_Shop.Models
{
    class Battery
    {
        private string model;
        private double life;

        public Battery(string batteryModel, double batteryLife)
        {
            this.Model = batteryModel;
            this.Life = batteryLife;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.model = value;
                }
                else
                {
                    throw new Exception("Empty string");
                }
            }
        }

        public double Life
        {
            get
            {
                return this.life;
            }
            set
            {
                if (value >= 0)
                {
                    this.life = value;
                }
                else
                {
                    throw new Exception("Numeric data cannot be negative");
                }
            }
        }
    }
}