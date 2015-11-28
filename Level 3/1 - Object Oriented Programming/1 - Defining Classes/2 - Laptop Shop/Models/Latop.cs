using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Laptop_Shop.Models
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private decimal price;
        private Battery battery;

        public Laptop(string model, decimal price) : this(model, null, null, 0, null, null, null, null, 0, price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, string processor, int ram, string hdd, decimal price) : this(model, null, processor, ram, null, hdd, null, null, 0, price)
        {
            this.Model = model;
            this.Processor = processor;
            this.RAM = ram;
            this.HDD = hdd;
            this.Price = price;
        }

        public Laptop(string model, string manufacturer,
            string processor, int ram, string graphicsCard, string hdd, string screen, string batteryModel, double batteryLife, decimal price)
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            battery = new Battery(batteryModel, batteryLife);
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
                    throw new Exception("Model name cannot be empty!");
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new Exception("Price cannot be a negative number!");
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new Exception("Manufacturer cannot be empty!");
                }
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.processor = value;
                }
                else
                {
                    throw new Exception("Empty string");
                }
            }
        }

        public int RAM
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value >= 0)
                {
                    this.ram = value;
                }
                else
                {
                    throw new Exception("Ram capacity cannot be a negative number!");
                }
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.graphicsCard = value;
                }
                else
                {
                    throw new Exception("Graphics card name cannot be left empty!");
                }
            }
        }

        public string HDD
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.hdd = value;
                }
                else
                {
                    throw new Exception("HDD cannot be left empty!");
                }
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.screen = value;
                }
                else
                {
                    throw new Exception("Screen description cannot be left empty!");
                }
            }
        }

        public string ToString()
        {
            string result = "";
            result += "Model: " + this.Model + "\n\r";
            if (this.Manufacturer != null)
            {
                result += "Manufacturer: " + this.Manufacturer + "\n\r";
            }
            if (this.Processor != null)
            {
                result += "Processor: " + this.Processor + "\n\r";
            }
            if (this.RAM > 0)
            {
                result += "RAM: " + this.RAM + " GB" + "\n\r";
            }
            if (this.GraphicsCard != null)
            {
                result += "Graphics Card: " + this.GraphicsCard + "\n\r";
            }
            if (this.HDD != null)
            {
                result += "HDD: " + this.HDD + "\n\r";
            }
            if (this.Screen != null)
            {
                result += "Screen: " + this.Screen + "\n\r";
            }
            if (battery.Model != null)
            {
                result += "Batery: " + battery.Life + "\n\r";
            }
            if (battery.Life > 0)
            {
                result += "Battery Life: " + battery.Life + "hours" + "\n\r";
            }
            result += "Price: " + this.Price + " lv" + "\n\r";
            return result;
        }
    }
}
