using System;

namespace UnicodeCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            char uniChar = '\u002A';
            Console.WriteLine("The unicode for the \"{0}\" symbol is {1}",uniChar,(int)uniChar);
        }
    }
}
