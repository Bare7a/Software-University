using System;

namespace Matrix
{
    class Matrix
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number between 1 and 20: ");
            byte num = byte.Parse(Console.ReadLine());
            if (num < 0 || num > 20)
            {
                Console.WriteLine("Wrong input! The number must be between 1 and 20!");
            }
            else
            {
                for (int i=0; i < num; i++)
                {
                    for (int j=1; j <= num; j++)
                    {
                        Console.Write("{0} ",i+j);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
