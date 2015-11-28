namespace _06.BitArray
{
    using System;
    using System.Numerics;
    using ExtensionMethods;

    public class MainProgram
    {
        public static void Main(string[] args)
        {
            var num = new BitArray(250);
            num[0] = 1;
            num[248] = 1;
            Console.WriteLine(num);
            
            // Using external library to validate the calculations
            var a = BigInteger.Parse("452312848583266388373324160190187140051835877600158453279131187530910662657");
            Console.WriteLine(Environment.NewLine + a.ToBinaryString());
        }
    }
}