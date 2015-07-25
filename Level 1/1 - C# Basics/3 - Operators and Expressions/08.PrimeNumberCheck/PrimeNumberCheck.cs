using System;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number from 1 to 100: ");
            byte num = byte.Parse(Console.ReadLine());
            byte count = num;
            bool isPrime = true;
            while(count>1){
                count--;
                if ((count != 1) && ((num % count) == 0))
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine("{0} is prime number: {1}",num,isPrime);
        }
    }
}
