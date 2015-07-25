using System;


namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? nullInt = null;
            Console.WriteLine("Integer variable with null value = " + nullInt);
            Console.WriteLine("Integer variable with null value plus 10 = " + (nullInt + 10));
            double? nullDouble = null;
            Console.WriteLine("Double variable with null value = " + nullDouble);
            Console.WriteLine("Double variable with null value plus 10 = " + (nullDouble + 10));
        }
    }
}
