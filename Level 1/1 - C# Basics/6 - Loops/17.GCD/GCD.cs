using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int b = int.Parse(Console.ReadLine());
            int gcd=1;
            int max=Math.Max(Math.Abs(a),Math.Abs(b));
            bool check = true;
            do
            {
                if (a % max == 0 && b % max == 0)
                {
                    gcd = max;
                    check = false;
                }
                max--;
            } while (check);
            Console.WriteLine("The greatest common divisor of {0} and {1} is {2}",a,b,gcd);
        }
    }
}
