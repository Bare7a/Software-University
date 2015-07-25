using System;

namespace DivideBy7and5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int num = int.Parse(Console.ReadLine());
            bool isDiv = (num % 5 == 0) && (num % 7 == 0);
            Console.WriteLine("Number {0} can be divided by 7 and 5 = {1}", num, isDiv);
        }
    }
}
