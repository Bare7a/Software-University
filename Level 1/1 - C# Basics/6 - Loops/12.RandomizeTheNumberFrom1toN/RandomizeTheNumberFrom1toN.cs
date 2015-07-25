using System;

namespace RandomizeTheNumberFrom1toN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number equal or heigher than 1: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Incorrect Input! The number must be heigher or equal to 1!");
            }
            else
            {
                int[] number = new int[n];
                bool[] check = new bool[n];
                int count=0;
                for (int i = 1; i <= n; i++)
                {
                    number[i-1] = i;
                    check[i-1] = false;
                }
                Random rand = new Random();
                int randNum;
                do
                {
                    randNum = rand.Next(0, n);
                    if (check[randNum] == false)
                    {
                        Console.Write("{0} ", number[randNum]);
                        check[randNum] = true;
                        count++;
                    }
                } while (count != n);
                Console.WriteLine();
            }
        }
    }
}
