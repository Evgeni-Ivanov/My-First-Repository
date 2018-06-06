using System;
using System.Linq;

namespace _03._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

            int k = arr.Length / 4;

            int[] leftArray = GetPart(arr, 0, k);
            int[] middleArray = GetPart(arr, k, 2 * k);
            int[] rightArray = GetPart(arr, 3 * k, k);

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);

            int[] mergedLeftAndRightArray = new int[2 * k];

            int index = 0;
            for (int i = 0; i < k; i++)
            {
                mergedLeftAndRightArray[index++] = leftArray[i];
            }
            for (int i = 0; i < k; i++)
            {
                mergedLeftAndRightArray[index++] = rightArray[i];
            }


            //This cycle prints the sum of indexes of mergedLeftAndRightArray and middleArray.
            for (int i = 0; i < middleArray.Length /*or*/ /*mergedLeftAndRightArray.Length*/; i++)
            {
                int sum = mergedLeftAndRightArray[i] + middleArray[i];
                Console.Write($"{sum} ");
            }
            Console.WriteLine();
        }

        private static int[] GetPart(int[] arr, int startIndex, int size)
        {
            int[] part = new int[size];

            for (int i = startIndex; i < size + startIndex; i++)
            {
                part[i - startIndex] = arr[i];
            }

            return part;
        }
    }
}
