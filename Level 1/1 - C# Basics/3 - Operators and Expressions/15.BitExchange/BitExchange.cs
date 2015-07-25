using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class BitsExchange
    {
        static void Main()
        {
            Console.Write("Input number: ");
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine("Binary of the number: {0}", Convert.ToString(num, 2).PadLeft(32, '0'));
            uint firstBits = (num >> 3) & 7;
            uint secondBits = (num >> 24) & 7;
            uint maskFirstBits = 7 << 3;
            uint maskSecondBits = 7 << 24;
            num = num & ~maskFirstBits | (secondBits << 3);
            num = num & ~maskSecondBits | (firstBits << 24);
            Console.WriteLine("Result: {0}", num);
            Console.WriteLine("Binary of the result: {0}", Convert.ToString(num, 2).PadLeft(32, '0'));
        }
    }
}
