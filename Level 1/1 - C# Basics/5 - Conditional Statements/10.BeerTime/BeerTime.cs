using System;

namespace BeerTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the time in \"hh:mm tt\" format: ");
            DateTime time = DateTime.Parse(Console.ReadLine());
            DateTime startBeerTime = Convert.ToDateTime("01:00 PM");
            DateTime endBeerTime = Convert.ToDateTime("03:00 AM");
            if (time >= startBeerTime || time < endBeerTime)
            {
                Console.WriteLine("Beer Time!");
            }
            else
            {
                Console.WriteLine("Non-Beer Time.");
            }
        }
    }
}
