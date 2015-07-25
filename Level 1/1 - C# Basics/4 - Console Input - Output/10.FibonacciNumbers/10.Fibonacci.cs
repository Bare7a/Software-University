using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("0 ");
            if (n > 0)
            {
                int f1=0;
                int f2=1;
                int swap;
                for (int i = 0; i < n-1; i++)
                {
                    Console.Write(f2 + " ");
                    swap = f2;
                    f2 = f2 + f1;
                    f1 = swap;
                }
            }
        }
    }
}
