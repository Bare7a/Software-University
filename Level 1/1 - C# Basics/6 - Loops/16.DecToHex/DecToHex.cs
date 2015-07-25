using System;

namespace DecToHex
{
    class DecToHex
    {
        static void Main(string[] args)
        {
            Console.Write("Input a decimal number: ");
            long dec = long.Parse(Console.ReadLine());
            long dec1 = dec;
            string reminder;
            string hex = string.Empty;
            while (dec1 > 0)
            {
                reminder = Convert.ToString(dec1 % 16);
                switch(reminder)
                {
                    case "10": reminder = "A";break;
                    case "11": reminder = "B"; break;
                    case "12": reminder = "C"; break;
                    case "13": reminder = "D"; break;
                    case "14": reminder = "E"; break;
                    case "15": reminder = "F"; break;
                }
                dec1 /= 16;
                hex = reminder + hex;
            }
            Console.WriteLine("The hexadecimal number of {0} is {1}", dec, hex);
        }
    }
}
