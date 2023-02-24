using System;

namespace Practical_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter array size: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int product = 1;
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter element with index {i}:");
                array[i] = Convert.ToInt32(Console.ReadLine());
                product *= array[i];
            }
            Console.WriteLine($"Product of array elements is {product}:");
        }
    }
}