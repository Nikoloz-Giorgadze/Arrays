using System;

namespace Practical_7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter array row size: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter array column size: ");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] firstMatrix = new int[row, column];
            int[,] secondMatrix = new int[row, column];
            Console.WriteLine("Fill first matrix.");
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {

                    Console.Write($"Enter number for index {r},{c}: ");
                    firstMatrix[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Fill second marix.");
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {

                    Console.Write($"Enter number for index {r},{c}: ");
                    secondMatrix[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Here is sum of two matrices");
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    Console.Write(firstMatrix[r, c] + secondMatrix[r,c]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}