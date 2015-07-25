using System;

namespace NumbersFrom1toN
{
    class NumbersFrom1toN
    {
        static void Main(string[] args)
        {
            Console.Write("Write a possitive number higher or equal to 1: ");
            uint num = uint.Parse(Console.ReadLine());
            if (num >= 1)
            {
                for (int i = 1; i <= num;i++ )
                {
                    Console.Write("{0} ",i);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The number must be equal or higher than 1!");
            }
        }
    }
}
