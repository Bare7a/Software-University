using System;

namespace GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how much do you weight in kilograms: ");
            double weightOnTheEarth = double.Parse(Console.ReadLine());
            double weightOnTheMoon = (weightOnTheEarth * 0.17);
            Console.WriteLine("You weight {0} on the Moon.",weightOnTheMoon);
        }
    }
}
