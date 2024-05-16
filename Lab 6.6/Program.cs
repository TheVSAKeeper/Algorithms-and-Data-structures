using System;
using System.Collections.Generic;

namespace Lab_6._6
{
    internal static class Program
    {
        public static void Main()
        {
            List<int[]> arrays = new List<int[]>
            {
                new[] { 1, 3, 2, 5, 7, 9, 10 },
                new[] { 5, 7, 9, 10, 12, 3 }
            };

            PerformSort(arrays, BubbleSort, OptimizedBubbleSort, BidirectionalBubbleSort, ShakerSort);
        }

        private static void PerformSort(List<int[]> arrays, params Action<int[]>[] sorts)
        {
            foreach (int[] array in arrays)
            {
                Console.WriteLine($"\nИсходный массив: {string.Join(", ", array)}");

                foreach (Action<int[]> sort in sorts)
                {
                    int[] sortingArray = (int[])array.Clone();
                    sort.Invoke(sortingArray);
                }
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

        private static void BidirectionalBubbleSort(int[] array)
        {
            int comparisonCount = 0;
            int swapCount = 0;

            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    comparisonCount++;

                    if (array[i] > array[i + 1])
                    {
                        swapCount++;
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    comparisonCount++;

                    if (array[i] < array[i - 1])
                    {
                        swapCount++;
                        Swap(ref array[i], ref array[i - 1]);
                    }
                }

                left++;
            }

            PrintSortResults("методом обмена (пузырьком) с чередованием направлений", comparisonCount, swapCount, array);
        }

        private static void ShakerSort(int[] array)
        {
            int comparisonCount = 0;
            int swapCount = 0;

            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                bool isElementsSwapped = false;

                for (int i = left; i < right; i++)
                {
                    comparisonCount++;

                    if (array[i] > array[i + 1])
                    {
                        isElementsSwapped = true;

                        swapCount++;
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    comparisonCount++;

                    if (array[i] < array[i - 1])
                    {
                        isElementsSwapped = true;

                        swapCount++;
                        Swap(ref array[i], ref array[i - 1]);
                    }
                }

                left++;

                if (isElementsSwapped == false)
                    break;
            }

            PrintSortResults("шейкер-сортировка", comparisonCount, swapCount, array);
        }
    }
}