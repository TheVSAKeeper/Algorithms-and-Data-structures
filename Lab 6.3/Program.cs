using System;

namespace Lab_6._3
{
    internal static class Program
    {
        private static void Main()
        {
            int[] array = { 5, 1, -4, 8, -3, 0, 1, -8, 9 };
            Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");

            SelectionSortNegative(array);
            Console.WriteLine("Сортировка простым выбором отрицательных элементов массива.");
            Console.WriteLine($"Отсортированный массив: {string.Join(", ", array)}");
        }

        private static void Swap(ref int firstElement, ref int secondElement)
        {
            (firstElement, secondElement) = (secondElement, firstElement);
        }

        private static void SelectionSortNegative(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;

                if (array[i] >= 0)
                    continue;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex] && array[j] < 0)
                        minIndex = j;
                }

                if (array[minIndex] < array[i])
                    Swap(ref array[i], ref array[minIndex]);
            }
        }
    }
}