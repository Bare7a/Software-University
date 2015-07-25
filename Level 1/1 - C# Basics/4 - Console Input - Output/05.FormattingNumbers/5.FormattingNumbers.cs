using System;

namespace FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            do
            {
                Console.WriteLine("Input the first number (0-500): ");
                num1 = int.Parse(Console.ReadLine());
            } while (num1 < 0 || num1 > 500);
            string num1Bin = Convert.ToString(num1, 2).PadLeft(10,'0');
            Console.Write("Input the second number: ");
            float num2 = float.Parse(Console.ReadLine());
            Console.Write("Input the third number: ");
            float num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("|{0,-10:X}|{1}| {2,10:F2}|{3,-10:F3}|",num1, num1Bin,num2,num3);
        }
    }
}