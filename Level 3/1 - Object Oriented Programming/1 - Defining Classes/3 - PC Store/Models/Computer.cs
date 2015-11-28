using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___PC_Store.Models
{
    public class Computer
    {
        private string name;
        private Component processor;
        private Component graphicsCard;
        private Component motherboard;

        public Computer(string name, Component processor, Component graphicsCard, Component motherboard)
        {
            this.Name = name;
            this.processor = processor;
            this.graphicsCard = graphicsCard;
            this.motherboard = motherboard;
        }

        public Computer(string name) : this(name, null, null, null)
        {
            this.Name = name;
        }

        public Computer(string name, Component processor, decimal price) : this(name, processor, null, null)
        {
            this.Name = name;
            this.processor = processor;
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
                    throw new Exception("Empty string");
                }
            }
        }

        public decimal CalculateComputerPrice()
        {
            decimal totalComputerPrice = 0;
            if (processor.Price >= 0)
            {
                totalComputerPrice += processor.Price;
            }
            if (graphicsCard.Price >= 0)
            {
                totalComputerPrice += graphicsCard.Price;
            }
            if (motherboard.Price >= 0)
            {
                totalComputerPrice += motherboard.Price;
            }

            return totalComputerPrice;
        }

        public void PrintComputerInformation()
        {
            Console.WriteLine(this.Name);
            if (processor.Price > 0)
            {
                Console.WriteLine("--> {0} price: {1:c}", processor.Name, processor.Price);
            }
            if (graphicsCard.Price > 0)
            {
                Console.WriteLine("--> {0} price: {1:c}", graphicsCard.Name, graphicsCard.Price);
            }
            if (motherboard.Price > 0)
            {
                Console.WriteLine("--> {0} price: {1:c}", motherboard.Name, motherboard.Price);
            }
            if (this.CalculateComputerPrice() > 0)
            {
                Console.WriteLine("Total Price: {0:c}", this.CalculateComputerPrice());
            }
        }
    }
}
