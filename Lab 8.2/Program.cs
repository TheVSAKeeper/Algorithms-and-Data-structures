using System;

namespace Lab_8._2
{
    internal static class Program
    {
        private static void Main()
        {
            int[] firstArray = { 5, 8, 9, 10, 12 };
            Console.WriteLine($"Первый массив: {string.Join(" ", firstArray)}");

            int[] secondArray = { 1, 3, 9, 15 };
            Console.WriteLine($"Второй массив: {string.Join(" ", secondArray)}");

            int[] mergedArray = MergeSortedArrays(firstArray, secondArray);
            Console.WriteLine($"Соединенный массив: {string.Join(" ", mergedArray)}");
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