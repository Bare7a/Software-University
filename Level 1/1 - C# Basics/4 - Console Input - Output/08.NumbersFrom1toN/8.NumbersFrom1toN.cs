using System;

namespace NumbersFrom1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
