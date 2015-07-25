using System;

namespace MinMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a positive number higher or equal to 2: ");
            uint num = uint.Parse(Console.ReadLine());
            if (num >= 2)
            {
                int[] arr = new int[num];
                int sum=0;
                for (int i = 0; i < num; i++)
                {
                    Console.Write("Input number [{0}]: ", i + 1);
                    arr[i] = int.Parse(Console.ReadLine());
                }
                int min = arr[0];
                int max = min;
                for (int i = 0; i < num; i++)
                {
                    sum += arr[i];
                    if (min > arr[i])
                    {
                        min = arr[i];
                    }
                    if (max < arr[i])
                    {
                        max = arr[i];
                    }
                }
                float avg = (float)sum / num;
                Console.WriteLine("Min = {0} \nMax = {1} \nSum = {2} \nAvg = {3:F2}",min,max,sum,avg);
            }
            else
            {
                Console.WriteLine("The number must be equal or higher than 2!");
            }
        }
    }
}
