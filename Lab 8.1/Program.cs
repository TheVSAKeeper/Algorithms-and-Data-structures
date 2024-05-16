using System;

namespace Lab_8._1
{
    internal static class Program
    {
        public static void Main()
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
            QuickSortHoara(array, 0, array.Length - 1);
        }

        private static void QuickSortHoara(int[] arr, int start, int end)
        {
            if (start >= end)
                return;

            int rightStart = PartOfSortHoara(arr, start, end);
            QuickSortHoara(arr, start, rightStart - 1);
            QuickSortHoara(arr, rightStart, end);
        }

        private static int PartOfSortHoara(int[] arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];

            while (left <= right)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    Swap(ref arr[left], ref arr[right]);
                    left++;
                    right--;
                }
            }

            return left;
        }
    }
}