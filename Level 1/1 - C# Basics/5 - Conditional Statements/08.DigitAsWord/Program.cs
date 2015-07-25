using System;

namespace DigitAsWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a digit (0-9): ");
            byte digit = byte.Parse(Console.ReadLine());
            switch (digit)
            {
                case 1: Console.WriteLine("One");break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                default: Console.WriteLine("{0} is not a digit!", digit);break ;
            }
        }
    }
}
