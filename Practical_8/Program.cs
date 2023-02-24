using System;
namespace Practical_8
{
    class Program
    {
        static void Main()
        {
            int row = 8;
            int column = 8;
            int[,] matrix = new int[row, column];
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    if (r < c)
                    {
                        matrix[r, c] = 1;
                    }
                    else
                    {
                        matrix[r, c] = 0;
                    }
                }
            }
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    Console.Write(matrix[r, c]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine('\n');
            for (int r = 0; r < row / 2; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    var temp = matrix[r, c];
                    matrix[r, c] = matrix[row - 1 - r, c];
                    matrix[row - 1 - r, c] = temp;
                }
            }

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