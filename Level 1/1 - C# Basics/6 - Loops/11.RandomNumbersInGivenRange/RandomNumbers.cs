using System;

namespace RandomNumbersInGivenRange
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Numbers to be generated: ");
            uint n = uint.Parse(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Wrong Input! The number must be 1 or heiger!");
            }
            else
            {
                Console.Write("Minimum number in range: ");
                int min = int.Parse(Console.ReadLine());
                Console.Write("Maximum number in range (must be equal or heigher than {0}): ",min);
                int max = int.Parse(Console.ReadLine())+1;
                if (max < min)
                {
                    Console.WriteLine("Wrong Input! The number must be {0} or heiger!", min);
                }
                else
                {
                    Random rand = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(rand.Next(min, max)+" ");
                    }
                }
            }
        }
    }
}
