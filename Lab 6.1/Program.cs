using System;

namespace Lab_6._1
{
    internal static class Program
    {
        public static void Main()
        {
            int[] array = { 5, 1, 4, 8, 3, 0, 1, 8, 9 };
            Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");

            PerformSort(array, SelectionSort, BubbleSort, InsertionSort);
        }

        private static void PerformSort(int[] array, params Action<int[]>[] sorts)
        {
            foreach (Action<int[]> sort in sorts)
            {
                int[] sortingArray = (int[])array.Clone();
                sort.Invoke(sortingArray);
            }
        }

        private static void PrintSortResults(string name, int comparisonCount, int swapCount, int[] sortedArray)
        {
            Console.WriteLine($"\nСортировка {name}" + $"\nКоличество операций сравнения: {comparisonCount}" + $"\nКоличество операций записи (присвоения): {swapCount}" + $"\nОтсортированный массив: {string.Join(", ", sortedArray)}");
        }

        private static void Swap(ref int firstElement, ref int secondElement)
        {
            (firstElement, secondElement) = (secondElement, firstElement);
        }

        private static void SelectionSort(int[] array)
        {
            int comparisonCount = 0;
            int swapCount = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    comparisonCount++;

                    if (array[j] < array[minIndex])
                        minIndex = j;
                }

                comparisonCount++;

                if (minIndex != i)
                {
                    Swap(ref array[i], ref array[minIndex]);
                    swapCount++;
                }
            }

            PrintSortResults("методом выбора", comparisonCount, swapCount, array);
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
                        Swap(ref array[j - 1], ref array[j]);
                        swapCount++;
                    }
                }
            }

            PrintSortResults("методом обмена (пузырьком)", comparisonCount, swapCount, array);
        }

        private static void InsertionSort(int[] array)
        {
            int comparisonCount = 0;
            int swapCount = 0;

            for (int i = 1; i < array.Length; i++)
            {
                int currentElement = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > currentElement)
                {
                    comparisonCount++;

                    array[j + 1] = array[j];
                    swapCount++;

                    j--;
                }

                array[j + 1] = currentElement;
            }

            PrintSortResults("методом вставки", comparisonCount, swapCount, array);
        }
    }
}