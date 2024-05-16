using System;

namespace Lab_8._3
{
    internal static class Program
    {
        private static void Main()
        {
            int[] array = { 5, 1, 4, 8, 3, 0, 1, 8, 9 };
            Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");

            MergeSort(ref array);
            Console.WriteLine($"Отсортированный массив: {string.Join(", ", array)}");
        }

        private static int[] MergeSort(ref int[] array)
        {
            if (array.Length <= 1)
                return array;

            int middle = array.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[array.Length - middle];

            for (int i = 0; i < middle; i++)
                left[i] = array[i];

            for (int i = middle; i < array.Length; i++)
                right[i - middle] = array[i];

            left = MergeSort(ref left);
            right = MergeSort(ref right);

            array = MergeSortedArrays(left, right);

            return array;
        }

        private static int[] MergeSortedArrays(int[] firstArray, int[] secondArray)
        {
            int[] mergedArray = new int[firstArray.Length + secondArray.Length];
            int firstIndex = 0;
            int secondIndex = 0;
            int mergedIndex = 0;

            while (firstIndex < firstArray.Length && secondIndex < secondArray.Length)
            {
                if (firstArray[firstIndex] < secondArray[secondIndex])
                {
                    mergedArray[mergedIndex] = firstArray[firstIndex];
                    firstIndex++;
                }
                else
                {
                    mergedArray[mergedIndex] = secondArray[secondIndex];
                    secondIndex++;
                }

                mergedIndex++;
            }

            while (firstIndex < firstArray.Length)
            {
                mergedArray[mergedIndex] = firstArray[firstIndex];
                firstIndex++;
                mergedIndex++;
            }

            while (secondIndex < secondArray.Length)
            {
                mergedArray[mergedIndex] = secondArray[secondIndex];
                secondIndex++;
                mergedIndex++;
            }

            return mergedArray;
        }
    }
}