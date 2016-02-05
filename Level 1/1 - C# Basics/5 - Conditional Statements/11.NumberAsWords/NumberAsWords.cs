using System;

namespace NumberAsWords
{
    class NumberAsWords
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number between [0...999]: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 0 && number <= 999)
            {
                string result = String.Empty;

                int hundreds = number / 100;
                int decimals = (number / 10) % 10;
                int digitals = number % 10;

                if (hundreds > 0)
                {
                    result += NumbersAsWords(hundreds) + " Hundred";
                    if (decimals != 0 || digitals != 0)
                    {
                        result += " and ";
                    }
                }

                if (decimals == 0 || decimals == 1)
                {
                    if (!(hundreds != 0 && (decimals + digitals) == 0))
                    {
                        result += NumbersAsWords(decimals * 10 + digitals);
                    }
                }
                else
                {
                    result += NumbersAsWords(decimals * 10);
                    if (decimals != 0)
                    {
                        result += "-" + NumbersAsWords(digitals);
                    }
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Incorrect Input!");
            }


        }

        private static string NumbersAsWords(int number)
        {
            switch (number)
            {
                case 0: return "Zero"; break;
                case 1: return "One"; break;
                case 2: return "Two"; break;
                case 3: return "Three"; break;
                case 4: return "Four"; break;
                case 5: return "Five"; break;
                case 6: return "Six"; break;
                case 7: return "Seven"; break;
                case 8: return "Eight"; break;
                case 9: return "Nine"; break;
                case 10: return "Ten"; break;
                case 11: return "Eleven"; break;
                case 12: return "Twelve"; break;
                case 13: return "Thirteen"; break;
                case 14: return "Fourteen"; break;
                case 15: return "Fifteen"; break;
                case 16: return "Sixteen"; break;
                case 17: return "Seventeen"; break;
                case 18: return "Eighteen"; break;
                case 19: return "Nineteen"; break;
                case 20: return "Twenty"; break;
                case 30: return "Thirty"; break;
                case 40: return "Forty"; break;
                case 50: return "Fifty"; break;
                case 60: return "Sixty"; break;
                case 70: return "Seventy"; break;
                case 80: return "Eighty"; break;
                case 90: return "Ninety"; break;
                default: return ""; break;
            }
        }
    }
}
