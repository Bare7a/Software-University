using System;

namespace QuotesInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string quotes1 = "The \"use\" of quotations causes difficulties.";
            string quotes2 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(quotes1);
            Console.WriteLine(quotes2);
        }
    }
}
