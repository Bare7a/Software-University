using System;

namespace HexToDec
{
    class HexToDec
    {
        static void Main(string[] args)
        {
            Console.Write("Write a hexadecimal number: ");
            string hex = Console.ReadLine();
            long dec = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                switch (hex[i])
                {
                    case 'A': dec += 10 * (long)Math.Pow(16, hex.Length - i - 1); break;
                    case 'B': dec += 11 * (long)Math.Pow(16, hex.Length - i - 1); break;
                    case 'C': dec += 12 * (long)Math.Pow(16, hex.Length - i - 1); break;
                    case 'D': dec += 13 * (long)Math.Pow(16, hex.Length - i - 1); break;
                    case 'E': dec += 14 * (long)Math.Pow(16, hex.Length - i - 1); break;
                    case 'F': dec += 15 * (long)Math.Pow(16, hex.Length - i - 1); break;
                    default:  dec += ((long)hex[i]-48)* (long)Math.Pow(16, hex.Length - i - 1); break;
                }
            }
            Console.WriteLine("The decimal number of {0} is {1}",hex,dec);
        }
    }
}
