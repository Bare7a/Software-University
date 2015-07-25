using System;

namespace DecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a decimal number: ");
            long dec = long.Parse(Console.ReadLine());
            long dec1 = dec;

            long remainder;
            string bin = string.Empty;
            while (dec1 > 0)
            {
                remainder = dec1 % 2;
                dec1 /= 2;
                bin = remainder.ToString() + bin;
            }
            Console.WriteLine("The binary number of {0} is {1}", dec, bin);
        }
    }
}
