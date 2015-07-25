using System;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int abcd = int.Parse(Console.ReadLine());
            int a = abcd / 1000;
            int b = (abcd / 100) % 10;
            int c = (abcd / 10) % 10;
            int d = abcd % 10;
            Console.WriteLine("Sum of digits: {0} ",a+b+c+d);
            Console.WriteLine("Reversed order: {0}{1}{2}{3}",d,c,b,a);
            Console.WriteLine("Last digit infront: {0}{1}{2}{3}",d,a,b,c);
            Console.WriteLine("Second and the third digit exchanged: {0}{1}{2}{3}",a,c,b,d);
        }
    }
}
