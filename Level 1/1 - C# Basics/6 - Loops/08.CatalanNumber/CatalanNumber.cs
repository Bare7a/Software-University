using System;
using System.Numerics;

namespace CatalanNumber
{
    class CatalanNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number between 0 and 100: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0 || n > 100)
            {
                Console.WriteLine("Incorrect input! The number must be between 0 and 100!");
            }
            else
            {
                int[] a = new int[100];
                int[] b = new int[100];
                int i;
                int j;
                int x;

                BigInteger sum = 1;
                for (i = 0; i < 2 * n; i++)
                {
                    if (i < n)
                    {
                        a[i] = i + 1;
                    }
                    if (i > n)
                    {
                        b[i - n - 1] = i + 1;
                    }
                }
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n - 1; j++)
                    {
                        if (a[i] != 1 && b[j] % a[i] == 0)
                        {
                            b[j] = b[j] / a[i];
                            a[i] = 1;
                        }
                        else if (b[j] != 1 && a[i] % b[j] == 0)
                        {
                            a[i] = a[i] / b[j];
                            b[j] = 1;
                        }
                    }
                }
                for (i = 0; i < n; i++)
                {
                    if (a[i] != 1)
                    {
                        for (j = 0; j < n - 1; j++)
                        {
                            if (b[j] != 1)
                            {
                                x = Math.Min(a[i], b[j]);
                                do
                                {
                                    if (a[i] % x == 0 && b[j] % x == 0)
                                    {
                                        a[i] = a[i] / x;
                                        b[j] = b[j] / x;
                                    }
                                    x--;
                                } while (x > 1);
                            }
                        }
                    }
                }
                for (i = 0; i < n - 1; i++)
                {
                    sum *= b[i];
                }
                Console.WriteLine("Sum: {0}", sum); ;
            }
        }
    }
}
