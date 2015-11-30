using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___PC_Store.Models
{
    public class Component
    {
        private string name;
        private decimal price;

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != string.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new Exception("Component name cannot be empty!");
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
    }
}
