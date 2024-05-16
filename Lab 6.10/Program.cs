using System;

namespace Lab_6._10
{
    internal static class Program
    {
        private static void Main()
        {
            int[] array = { 7, 10, 3, 5, 15, 9, 6, 12, 8 };
            Console.WriteLine($"Исходный массив : {string.Join(" ", array)}");

            QuadraticSelectionSort(array);
            Console.WriteLine($"Отсортированный массив: {string.Join(" ", array)}");
        }

        private static void QuadraticSelectionSort(int[] array)
        {
            int arrayLength = array.Length;
            int groupCount = (int)Math.Round(Math.Sqrt(arrayLength));
            int[][] groups = new int[groupCount][];
            int offset = 0;

            for (int i = 0; i < groupCount; i++)
            {
                int groupSize = arrayLength / groupCount;

                if (i < arrayLength % groupCount)
                    groupSize++;

                groups[i] = new int[groupSize];
                Array.Copy(array, offset, groups[i], 0, groupSize);
                offset += groupSize;
            }

            int[] minArray = new int[groupCount];

            // Находим минимальный элемент в каждой группе и записываем его в массив minArray
            for (int i = 0; i < groupCount; i++)
                minArray[i] = Min(groups[i]);

            // Сортируем исходный массив, выбирая на каждом шаге минимальный элемент из массива minArray
            // и заменяя его на следующий минимальный элемент из соответствующей группы
            for (int i = 0; i < arrayLength; i++)
            {
                int index = MinIndex(minArray);
                array[i] = minArray[index];
                minArray[index] = Min(groups[index]);
            }
        }

        private static int Min(int[] array)
        {
            int index = MinIndex(array);
            int min = array[index];

            array[index] = int.MaxValue;
            return min;
        }

        private static int MinIndex(int[] array)
        {
            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (min <= array[i])
                    continue;

                min = array[i];
                index = i;
            }

            return index;
        }
    }
}