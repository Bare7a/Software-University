using System;


class PrintSequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i < 12; i++)
        {
            Console.Write("{0}", i*(Math.Pow(-1,i)));
            if (i != 11)
            {
                Console.Write(",");
            }
            else
            {
                Console.WriteLine();
            }
        }

    }
}
