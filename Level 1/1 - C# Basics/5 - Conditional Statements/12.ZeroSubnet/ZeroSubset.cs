using System;

class ZeroSubset
{
    static void Main()
    {
        Console.Write("Input the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Input the third number: ");
        int num3 = int.Parse(Console.ReadLine());
        Console.Write("Input the fourth number: ");
        int num4 = int.Parse(Console.ReadLine());
        Console.Write("Input the fifth number: ");
        int num5 = int.Parse(Console.ReadLine());
        bool isZeroSubset = false;
        if ((num1 + num2 + num3 + num4 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", num1, num2, num3, num4, num5);
        }
        if ((num1 + num2 + num3 + num4) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", num1, num2, num3, num4);
        }
        if ((num1 + num2 + num3 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", num1, num2, num3, num5);
        }
        if ((num1 + num2 + num4 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", num1, num2, num4, num5);
        }
        if ((num1 + num3 + num4 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", num1, num3, num4, num5);
        }
        if ((num2 + num3 + num4 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", num2, num3, num4, num5);
        }
        if ((num1 + num2 + num3) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} = 0", num1, num2, num3);
        }
        if ((num1 + num2 + num4) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} = 0", num1, num2, num4);
        }
        if ((num1 + num2 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} = 0", num1, num2, num5);
        }
        if ((num1 + num3 + num4) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} = 0", num1, num3, num4);
        }
        if ((num1 + num3 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} = 0", num1, num3, num5);
        }
        if ((num1 + num4 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} = 0", num1, num4, num5);
        }
        if ((num2 + num4 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} = 0", num2, num4, num5);
        }
        if ((num3 + num4 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} = 0", num3, num4, num5);
        }
        if ((num2 + num3 + num4) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} = 0", num2, num3, num4);
        }
        if ((num2 + num3 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} = 0", num2, num3, num5);
        }
        if ((num1 + num2) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} = 0", num1, num2);
        }
        if ((num1 + num3) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} = 0", num1, num3);
        }
        if ((num1 + num4) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} = 0", num1, num4);
        }
        if ((num1 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} = 0", num1, num5);
        }
        if ((num2 + num3) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} = 0", num2, num3);
        }
        if ((num2 + num4) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} = 0", num2, num4);
        }
        if ((num2 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} = 0", num2, num5);
        }
        if ((num3 + num4) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} = 0", num3, num4);
        }
        if ((num3 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} = 0", num3, num5);
        }
        if ((num4 + num5) == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0} + {1} = 0", num4, num5);
        }
        if (num1 == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0}", num1);
        }
        if (num2 == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0}", num2);
        }
        if (num3 == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0}", num3);
        }
        if (num4 == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0}", num4);
        }
        if (num5 == 0)
        {
            isZeroSubset = true;
            Console.WriteLine("{0}", num5);
        }
        if (!isZeroSubset)
        {
            Console.WriteLine("There aren't any zero subsets.");
        }
        Console.ReadLine();
    }
}