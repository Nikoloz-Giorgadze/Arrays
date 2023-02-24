using System;
using System.Drawing;
using System.Threading.Channels;

namespace Practical_5
{
    class Program
    {
        static void Main()
        {
            int i, j, k, isUnique;
            Console.WriteLine("Enter number for array size: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrayLength];
            for (i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter number for array with index {i}:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < arrayLength; i++)
            {
                isUnique = 1;
                for (j = i + 1; j < arrayLength; j++)
                {
                    if (array[i] == array[j])
                    {
                       
                        for (k = j; k < arrayLength - 1; k++)
                        {
                            array[k] = array[k + 1];
                        }

                        arrayLength--;
                        j--;
                        isUnique = 0;
                    }

                }
                if (isUnique != 1)
                {
                    for (j = i; j < arrayLength - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }

                    arrayLength --;
                    i--;
                }
            }
            Console.WriteLine("All unique elements in the array are: ");
            for (i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }


        }
    }
}