using System;

namespace TrailingZeroes
{
    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number heigher than 0: ");
            int num = int.Parse(Console.ReadLine());
            int num1 = num;
            if (num < 1)
            {
                Console.WriteLine("Wrong input! The number must be heigher than 0!");
            }
            else
            {
                int zeros=0;
                while (num1 > 1)
                {
                    zeros += num1 / 5;
                    num1 /= 5;
                }
                Console.WriteLine(" {0} Trailing Zeros in {1}!",zeros,num);
            }
        }
    }
}
