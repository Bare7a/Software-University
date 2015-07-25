using System;

namespace SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number between 1 and 20: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 1 || num > 20)
            {
                Console.Write("Incorrect Input! The number must be between 1 and 20!");
            }
            else
            {
                int col = 0;
                int row = 0;
                string direction="right";
                int[,] matrix = new int[num, num];
                for (int i = 1; i <= num*num; i++)
                {
                    if (direction == "right" && (col > num - 1 || matrix[row, col] != 0))
                    {
                        direction = "down";
                        col--;
                        row++;
                    }
                    if (direction == "down" && (row > num - 1 || matrix[row, col] != 0))
                    {
                        direction = "left";
                        row--;
                        col--;
                    }
                    if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                    {
                        direction = "up";
                        col++;
                        row--;
                    }

                    if (direction == "up" && row < 0 || matrix[row, col] != 0)
                    {
                        direction = "right";
                        row++;
                        col++;
                    }

                    matrix[row, col] = i;

                    if (direction == "right")
                    {
                        col++;
                    }
                    if (direction == "down")
                    {
                        row++;
                    }
                    if (direction == "left")
                    {
                        col--;
                    }
                    if (direction == "up")
                    {
                        row--;
                    }
                }
                for (int r = 0; r < num; r++)
                {
                    for (int c = 0; c < num; c++)
                    {
                        Console.Write("{0,4}",matrix[r,c]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
