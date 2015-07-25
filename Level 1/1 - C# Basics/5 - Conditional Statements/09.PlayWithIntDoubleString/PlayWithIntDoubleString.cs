using System;

namespace PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.Write("Please choose a type: \n1 --> int\n2 --> double\n3 --> string\nChoice: ");
            byte choice = byte.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: 
                    Console.Write("Input your int number: "); 
                    int num1 = int.Parse(Console.ReadLine())+1; 
                    Console.WriteLine(num1);break;
                case 2:
                    Console.Write("Input your double number: ");
                    double num2 = double.Parse(Console.ReadLine()) + 1;
                    Console.WriteLine(num2); break;
                case 3:
                    Console.Write("Input your string: ");
                    string text = Console.ReadLine()+"*";
                    Console.WriteLine(text); break;
                default:
                    Console.WriteLine("Invalid choice!");break;
            }
        }
    }
}
