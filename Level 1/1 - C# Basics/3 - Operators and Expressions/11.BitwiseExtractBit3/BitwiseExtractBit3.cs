using System;

namespace BitwiseExtractBit3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int num = int.Parse(Console.ReadLine());
            int bit = (int)(num >> 3) & 1;
            Console.WriteLine("The third bit of {0} is {1}",num,bit);
        }
    }
}
