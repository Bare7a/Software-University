using System;

namespace PrintASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine("{0} = {1}",(int)i,(char)i);
            }
        }
    }
}
