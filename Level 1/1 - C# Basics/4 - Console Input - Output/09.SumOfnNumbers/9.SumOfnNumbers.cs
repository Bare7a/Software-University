using System;

namespace SumOfnNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            double number;
            double sum=0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Input a number: ");
                number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The sum of the numbers is: {0}",sum);
        }
    }
}
