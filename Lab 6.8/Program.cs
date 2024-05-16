using System;

namespace Lab_6._8
{
    internal abstract class Program
    {
        public static void Main()
        {
            int[] array = { 5, 1, 4, 8, 3, 0, 1, 8, 9 };
            Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");

            BinaryInsertionSort(array);
            Console.WriteLine($"Отсортированный массив: {string.Join(", ", array)}");
        }

        private static void BinaryInsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int currentElement = array[i];
                int j = i - 1;

                int left = 0;
                int right = i - 1;

                while (left <= right)
                {
                    int middle = left + (right - left) / 2;

                    if (currentElement < array[middle])
                        right = middle - 1;
                    else
                        left = middle + 1;
                }

                while (j >= left)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[left] = currentElement;
            }
        }
    }
}