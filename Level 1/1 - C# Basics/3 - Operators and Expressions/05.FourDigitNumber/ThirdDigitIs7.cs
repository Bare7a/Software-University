using System;

namespace FourDigitNumber
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int num = int.Parse(Console.ReadLine());
            bool isSeven = ((num / 100)%10) == 7;
            Console.WriteLine("The third number of {0} is 7: {1}",num,isSeven);
        }
    }
}
