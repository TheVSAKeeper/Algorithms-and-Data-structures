using System;

namespace Lab_6._9
{
    internal static class Program
    {
        private static void Main()
        {
            int[] array = { 5, 1, 4, 8, 3, 0, 1, 8, 9 };
            int[] increments = { 4, 2, 1 };

            Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");

            ShellSort(array, increments);
            Console.WriteLine($"Отсортированный массив: {string.Join(", ", array)}");
        }

        private static void ShellSort(int[] array, int[] increments)
        {
            foreach (int increment in increments)
            {
                for (int i = increment; i < array.Length; i++)
                {
                    int currentElement = array[i];
                    int j = i;

                    while (j >= increment && array[j - increment] > currentElement)
                    {
                        array[j] = array[j - increment];
                        j -= increment;
                    }

                    array[j] = currentElement;
                }
            }
        }
    }
}