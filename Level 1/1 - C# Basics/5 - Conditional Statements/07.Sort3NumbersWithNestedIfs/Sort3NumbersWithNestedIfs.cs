using System;

namespace Sort3NumbersWithNestedIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Input third number: ");
            double num3 = double.Parse(Console.ReadLine());
            double swap;
            if (num1 < num2)
            {
                swap = num1;
                num1 = num2;
                num2 = swap;
                if (num1 < num3)
                {
                    swap = num1;
                    num1 = num3;
                    num3 = swap;
                    if (num2 < num3)
                    {
                        swap = num2;
                        num2 = num3;
                        num3 = swap;
                    }
                }
                else
                {
                    if (num2 < num3)
                    {
                        swap = num2;
                        num2 = num3;
                        num3 = swap;
                    }
                }
            }
            else
            {
                if (num1 < num3)
                {
                    swap = num1;
                    num1 = num3;
                    num3 = swap;
                    if (num2 < num3)
                    {
                        swap = num2;
                        num2 = num3;
                        num3 = swap;
                    }
                }
                else
                {
                    if (num2 < num3)
                    {
                        swap = num2;
                        num2 = num3;
                        num3 = swap;
                    }
                }
            }
            Console.WriteLine("{0} {1} {2}",num1,num2,num3);
        }
    }
}
