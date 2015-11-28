using System;
using System.Collections.Generic;
using System.Linq;
using _3___PC_Store.Models;

namespace _3___PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer veryExpensiveComputer = new Computer("Very Expensive Computer", new Component("Very Expensive Processor", 1600.00m), new Component(" Very Expensive Graphics Card", 1700.00m), new Component(" Very Expensive Motherboard", 1800.00m));
            Computer cheapComputer = new Computer("Cheap Computer", new Component("Cheap Processor", 20.00m), new Component("Cheap Graphics Card", 30.00m), new Component("Cheap Motherboard", 40.00m));
            Computer expensiveComputer = new Computer("Expensive Computer", new Component("Expensive Processor", 500.00m), new Component("Expensive Graphics Card", 600.00m), new Component("Expensive Motherboard", 700.00m));

            List<Computer> allComputers = new List<Computer>();
            allComputers.Add(cheapComputer);
            allComputers.Add(expensiveComputer);
            allComputers.Add(veryExpensiveComputer);

            foreach (Computer computer in allComputers.OrderBy(computer => computer.CalculateComputerPrice()))
            {
                computer.PrintComputerInformation();
                Console.WriteLine();
            }
        }
    }
}
