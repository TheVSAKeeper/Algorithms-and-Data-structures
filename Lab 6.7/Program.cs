using System;

namespace Lab_6._7
{
    internal static class Program
    {
        private static void Main()
        {
            int[] array = { 0, 5, -2, 3, -10 };
            Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");

            InsertionSort(array);
            Console.WriteLine($"Отсортированный массив: {string.Join(", ", array)}");
        }

        private static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int currentElement = array[i];
                int j = i - 1;

                array[0] = currentElement;

                while (array[0] < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = currentElement;
            }
        }
    }
}