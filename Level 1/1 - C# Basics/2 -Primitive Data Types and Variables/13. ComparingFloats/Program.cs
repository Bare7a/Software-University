using System;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal eps = 0.000001m;
            decimal firstNum = -0.0000007m;
            decimal secondNum = 0.00000007m;
            decimal absNum = Math.Abs(firstNum - secondNum);
            bool checkNum = absNum < eps;
            Console.WriteLine("{0} > {1}: {2}", eps, absNum, checkNum);
        }
    }
}
