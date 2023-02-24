using System;


namespace Practical_6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter array row size: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter array column size: ");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[row, column];
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    Console.Write($"Enter number for index {r},{c}: ");
                    matrix[r, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Here is matrix view in multidimensional array");
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    Console.Write(matrix[r, c]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}