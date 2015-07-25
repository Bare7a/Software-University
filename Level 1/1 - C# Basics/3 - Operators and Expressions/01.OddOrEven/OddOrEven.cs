using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int num = int.Parse(Console.ReadLine());
            bool isOdd = num % 2 != 0;
            Console.WriteLine("Number {0} is odd = {1}", num ,isOdd);
        }
    }
}
