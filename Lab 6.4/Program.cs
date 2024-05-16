using System;

namespace Lab_6._4
{
    internal static class Program
    {
        public static void Main()
        {
            int[] array = { 1, 3, 2, 5, 7, 9, 10 };
            Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");

            PerformSort(array, BubbleSort, OptimizedBubbleSort);
        }

        private static void PerformSort(int[] array, params Action<int[]>[] sorts)
        {
            foreach (Action<int[]> sort in sorts)
            {
                int[] sortingArray = (int[])array.Clone();
                sort.Invoke(sortingArray);
            }
        }

        private static void PrintSortResults(string sortName, int comparisonCount, int swapCount, int[] sortedArray)
        {
            Console.WriteLine($"\nСортировка {sortName}" + $"\nКоличество операций сравнения: {comparisonCount}" + $"\nКоличество операций записи (присвоения): {swapCount}" + $"\nОтсортированный массив: {string.Join(", ", sortedArray)}");
        }

        private static void Swap(ref int firstElement, ref int secondElement)
        {
            (firstElement, secondElement) = (secondElement, firstElement);
        }

        private static void BubbleSort(int[] array)
        {
            int comparisonCount = 0;
            int swapCount = 0;

            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    comparisonCount++;

                    if (array[j - 1] > array[j])
                    {
                        swapCount++;
                        Swap(ref array[j - 1], ref array[j]);
                    }
                }
            }

            PrintSortResults("методом обмена (пузырьком)", comparisonCount, swapCount, array);
        }

        private static void OptimizedBubbleSort(int[] array)
        {
            int comparisonCount = 0;
            int swapCount = 0;

            for (int i = array.Length - 1; i > 0; i--)
            {
                bool isElementsSwapped = false;

                for (int j = 1; j <= i; j++)
                {
                    comparisonCount++;

                    if (array[j - 1] > array[j])
                    {
                        isElementsSwapped = true;
                        swapCount++;
                        Swap(ref array[j - 1], ref array[j]);
                    }
                }

                if (isElementsSwapped == false)
                    break;
            }

            PrintSortResults("методом обмена (пузырьком) с исключенными лишними просмотрами", comparisonCount, swapCount, array);
        }
    }
}