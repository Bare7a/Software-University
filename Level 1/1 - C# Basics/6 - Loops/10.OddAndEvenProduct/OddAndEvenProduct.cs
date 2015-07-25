using System;


namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            Console.Write("Write numbers seperated by space: ");
            string[] numbers = Console.ReadLine().Split();
            int evenProduct=1;
            int oddProduct=1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenProduct *= Convert.ToInt32(numbers[i]);
                }
                else
                {
                    oddProduct *= Convert.ToInt32(numbers[i]);
                }
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("Is the even product the same as the odd product: Yes\nProduct = {0}", evenProduct);

            }
            else
            {
                Console.WriteLine("Is the even product the same as the odd product: No\nEven Product = {0}\nOdd Product = {1}", evenProduct,oddProduct);
            }
        }
    }
}
