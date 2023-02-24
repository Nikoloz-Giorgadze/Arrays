using System;

namespace Practical_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter size for array: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter number for index {i}:");
                for (int j = 0; j < 1; j++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("Here is your array in reverse order!");
            for (int i = arrayLength - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}