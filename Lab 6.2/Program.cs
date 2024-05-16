using System;

namespace Lab_6._2
{
    internal static class Program
    {
        private static void Main()
        {
            int[] array = { 5, 1, 4, 8, 3, 0, 1, 8, 9 };
            Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");

            QuickSort(array);
            Console.WriteLine($"Отсортированный массив методом Хоара: {string.Join(", ", array)}");
        }

        private static void Swap(ref int firstElement, ref int secondElement)
        {
            (firstElement, secondElement) = (secondElement, firstElement);
        }

        private static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);

                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(ref array[i], ref array[j]);
                }
            }

            Swap(ref array[i + 1], ref array[right]);
            return i + 1;
        }
    }
}