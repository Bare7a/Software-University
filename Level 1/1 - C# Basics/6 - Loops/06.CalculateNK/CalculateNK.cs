using System;

namespace CalculateNK
{
    class CalculateNK
    {
        static void Main(string[] args)
        {
            Console.Write("Input n (1<n<100): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n >= 1 && n <= 100)
            {
                Console.Write("Input k (1<k<{0}): ",n);
                uint k = uint.Parse(Console.ReadLine());
                if (k >= 1 && k <= 100 && k < n)
                {
                    uint n1=1;
                    for(uint i=1;i<=n;i++)
                    {
                        if (i> k &&i <= n)
                        {
                            n1 *= i;
                        }
                    }
                    Console.WriteLine("N!/K! = {0}", n1);
                }
                else
                {
                    Console.WriteLine("Incorrect input! k must be between 1 and {0}!",n);
                }
            }
            else
            {
                Console.WriteLine("Incorrect input! n must be between 1 and 100!");
            }
        }
    }
}
