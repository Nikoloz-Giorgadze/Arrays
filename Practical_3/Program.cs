using System;

namespace Practical_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter array size: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter element with index {i}:");
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine($"Sum of array elements is: {sum}");
        }
    }
}