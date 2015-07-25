using System;

namespace BinToDec
{
    class BinToDec
    {
        static void Main(string[] args)
        {
            Console.Write("Write a binary number: ");
            string bin = Console.ReadLine();
            long dec = 0;
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[bin.Length - i - 1] == '0') continue;
                dec += (long)Math.Pow(2, i);
            }
            Console.WriteLine("The decimal number of {0} is {1}", bin,dec);
        }
    }
}
