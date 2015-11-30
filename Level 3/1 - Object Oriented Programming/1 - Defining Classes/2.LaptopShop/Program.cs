using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2___Laptop_Shop.Models;

namespace _2___Laptop_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("HP 250 G2", 699.00m);
            Console.WriteLine(laptop.ToString());

            Laptop laptop2 = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 8, "ntel HD Graphics 4400", "128GB SSD", "13.3\"(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display", "Li-Ion, 4-cells, 2550 mAh", 4.5, 2259.00m);
            Console.WriteLine(laptop2.ToString());

            Laptop laptop3 = new Laptop("PRO", "8-core, 5 GHz", 32, "100 TB", 10000.00m);
            Console.WriteLine(laptop3.ToString());
        }
    }
}
