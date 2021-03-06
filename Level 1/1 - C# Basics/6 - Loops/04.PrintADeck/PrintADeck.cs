﻿using System;

namespace PrintADeck
{
    class PrintADeck
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    CardNumber(i);
                    CardType(j);
                }
                Console.WriteLine();
            }
        }
        static public void CardNumber(int number)
        {
            switch (number)
            {
                case 0: Console.Write("2"); break;
                case 1: Console.Write("3"); break;
                case 2: Console.Write("4"); break;
                case 3: Console.Write("5"); break;
                case 4: Console.Write("6"); break;
                case 5: Console.Write("7"); break;
                case 6: Console.Write("8"); break;
                case 7: Console.Write("9"); break;
                case 8: Console.Write("10"); break;
                case 9: Console.Write("J"); break;
                case 10: Console.Write("Q"); break;
                case 11: Console.Write("K"); break;
                case 12: Console.Write("A"); break;
                default: Console.WriteLine("Incorrect input!"); break;
            }
        }
        static public void CardType(int number)
        {
            switch (number)
            {
                case 0: Console.Write("♣ "); break;
                case 1: Console.Write("♦ "); break;
                case 2: Console.Write("♥ "); break;
                case 3: Console.Write("♠ "); break;
                default: Console.WriteLine("Incorrect inpu!"); break;
            }
        }
    }
}
