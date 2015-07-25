using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Input number: ");
        ulong num = ulong.Parse(Console.ReadLine());
        Console.Write("Input p: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Input q: ");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Input k: ");
        int k = int.Parse(Console.ReadLine());
        uint maskNum = 0;
        if (Math.Max(p, q) + k > 32)
        {
            Console.WriteLine("out of range");
        }
        else if (Math.Min(p, q) + k > Math.Max(p, q))
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            for (int i = 0; i < k; i++)
            {
                maskNum += (uint)Math.Pow(2, i);
            }

            uint mask = ((maskNum << p) | (maskNum << q));
            uint firstBitGroup = (uint)((num >> p) & maskNum);
            uint secondBitGroup = (uint)((num >> q) & maskNum);
            Console.WriteLine((num & (~mask)) | ((firstBitGroup << q) | (secondBitGroup << p)));
        }
    }
}