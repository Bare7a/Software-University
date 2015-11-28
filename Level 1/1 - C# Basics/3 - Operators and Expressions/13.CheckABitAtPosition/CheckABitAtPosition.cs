using System;

namespace CheckABitAtPosition
{
    class CheckABitAtPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Input position: ");
            int pos = int.Parse(Console.ReadLine());
            int bit = (int)(num >> pos) & 1;
            bool isOne = bit == 1;
            Console.WriteLine("The {0} bit of number {1} is 1: {2}", pos, num, isOne);
        }
    }
}
