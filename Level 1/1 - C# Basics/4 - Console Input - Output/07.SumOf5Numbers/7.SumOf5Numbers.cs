using System;

namespace SumOf5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 5 numbers separated by a space:");
            string[] numbers = new string[5];
            double sum = 0;
            numbers = Console.ReadLine().Split();
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Convert.ToDouble(numbers[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
