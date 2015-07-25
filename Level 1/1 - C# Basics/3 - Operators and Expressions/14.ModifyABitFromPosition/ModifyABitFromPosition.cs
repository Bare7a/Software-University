using System;

class ModifyABitFromPosition
{
    static void Main()
    {
        Console.Write("Input number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Check bit of position: ");
        int pos = int.Parse(Console.ReadLine());
        Console.Write("Input value of bit [0] or [1]: ");
        int val = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0'));

        if (val == 1)
        {
            int setOne = 1 << pos;
            int foundBitOne = num | setOne;
            Console.WriteLine(Convert.ToString(foundBitOne, 2).PadLeft(16, '0'));
            Console.WriteLine(foundBitOne);
        }
        else
        {
            int setZero = ~(1 << pos);
            int foundBitZero = num & setZero;
            Console.WriteLine(Convert.ToString(foundBitZero, 2).PadLeft(16, '0'));
            Console.WriteLine(foundBitZero);
        }
    }
}