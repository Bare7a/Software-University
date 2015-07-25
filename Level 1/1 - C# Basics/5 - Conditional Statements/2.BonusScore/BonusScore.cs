using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a score between [1] to [9]: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice > 0 && choice < 4)
            {
                choice = choice * 10;
                Console.WriteLine(choice);
            }
            else if (choice > 3 && choice < 7)
            {
                choice = choice * 100;
                Console.WriteLine(choice);
            }
            else if (choice > 6 && choice < 10)
            {
                choice = choice * 1000;
                Console.WriteLine(choice);
            }
            else
            {
                Console.WriteLine("Invalid Score");
            }
        }
    }
}
