using System;

namespace CheckForaPlayCard
{
    class CheckForaPlayCard
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string card = Console.ReadLine();
            if (card == "A" || card == "2" || card == "3" || card == "4" || card == "5" || card == "6" || card == "7" || card == "8" || card == "9" || card == "10" || card == "J" || card == "Q" || card == "K" || card == "A")
            {
                Console.WriteLine("Is [{0}] a valid card: yes",card);
            }
            else
            {
                Console.WriteLine("Is [{0}] a valid card: no",card);
            }
       }
    }
}
