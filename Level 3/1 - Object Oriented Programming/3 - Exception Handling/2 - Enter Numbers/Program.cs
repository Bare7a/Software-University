using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Enter_Numbers
{
    class Program
    {
        const int count = 10;

        static void Main(string[] args)
        {

            int start = 1;
            int end = 100;
            List<int> numbers = new List<int>();

            while (numbers.Count < count)
            {
                try
                {
                    int number = ReadNumber(start, end);
                    numbers.Add(number);
                    start = number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a number!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("This is not an integer!");

                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number is out of range");

                }
                catch (InfiniteLoopException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Console.Clear();
            Console.WriteLine("These are input numbers");
            numbers.ForEach(n => Console.WriteLine(n));
        }

        private static int ReadNumber(int start, int end)
        {

            Console.WriteLine("Enter number greater that {0} and less than {1}", start, end);
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number >= end || number <= start)
            {
                throw new ArgumentOutOfRangeException("Number is out of range");
            }
            if (count > end - number)
            {
                throw new InfiniteLoopException("There are not enough left numbers to complete task");
            }
            return number;
        }
    }
}
