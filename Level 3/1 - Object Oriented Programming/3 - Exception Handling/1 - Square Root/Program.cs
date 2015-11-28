using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Square_Root
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.Write("Input a positive number between [0...{0}]: ", int.MaxValue);
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double rootedNumber = Math.Sqrt(number);
                Console.WriteLine("Square root of {0} is {1}", number, rootedNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number must be greater than 0!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number must be bigger than 0 and smaller than {0}!", int.MaxValue);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }

        }
    }
}
