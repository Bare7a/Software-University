using System;

namespace NumbersDividedByGivenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Input end: ");
            int end = int.Parse(Console.ReadLine());
            int count=0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}
