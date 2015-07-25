using System;

namespace NumberAsWords
{
    class NumberAsWords
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number between 0 and 999: ");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 20)
            {
                NumFrom0to19and10s(num);
            }
            else if (num >= 21 && num <= 999)
            {
                if (num / 100 == 0)
                {
                    NumFrom0to19and10s((num / 10) * 10);
                    if (num % 10 != 0)
                    {
                        NumFrom0to19and10s(num % 10);
                    }
                }
                else
                {
                    NumFrom0to19and10s(num / 100);
                    Console.Write("Hundred ");
                    if (num % 100 > 19)
                    {
                        Console.Write("and ");
                        NumFrom0to19and10s((num % 100 / 10) * 10);
                        if (num % 10 != 0)
                        {
                            NumFrom0to19and10s(num % 10);
                        }
                    }
                    else if(num%100 !=0 && num%100<20)
                    {
                        Console.Write("and ");
                        NumFrom0to19and10s(num % 100);
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
            Console.WriteLine();
        }

        static public void NumFrom0to19and10s(int x)
        {
            switch (x)
            {
                case 0: Console.Write("Zero "); break;
                case 1: Console.Write("One "); break;
                case 2: Console.Write("Two "); break;
                case 3: Console.Write("Three "); break;
                case 4: Console.Write("Four "); break;
                case 5: Console.Write("Five "); break;
                case 6: Console.Write("Six "); break;
                case 7: Console.Write("Seven "); break;
                case 8: Console.Write("Eight "); break;
                case 9: Console.Write("Nine "); break;
                case 10: Console.Write("Ten "); break;
                case 11: Console.Write("Eleven "); break;
                case 12: Console.Write("Twelve "); break;
                case 13: Console.Write("Thirteen "); break;
                case 14: Console.Write("Fourteen "); break;
                case 15: Console.Write("Fifteen "); break;
                case 16: Console.Write("Sixteen "); break;
                case 17: Console.Write("Seventeen "); break;
                case 18: Console.Write("Eighteen "); break;
                case 19: Console.Write("Nineteen "); break;
                case 20: Console.Write("Twenty "); break;
                case 30: Console.Write("Thirty "); break;
                case 40: Console.Write("Forty "); break;
                case 50: Console.Write("Fifty "); break;
                case 60: Console.Write("Sixty "); break;
                case 70: Console.Write("Seventy "); break;
                case 80: Console.Write("Eighty "); break;
                case 90: Console.Write("Ninety "); break;
                default: Console.Write(""); break;
            }
        }

    }
}
