using System;

namespace Lab_4
{
    internal static class Program
    {
        public static void Main()
        {
            PerformTasks(Task1,
                Task2,
                Task3,
                Task4,
                Task5,
                Task6);
        }

        private static void PerformTasks(params Action[] tasks)
        {
            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine($"\n\tЗадание {i + 1}");
                tasks[i].Invoke();
                Console.WriteLine();
            }
        }

        private static void Task1()
        {
            int[] N = new int[20];
            int[] Y = new int[N.Length];

            FillArrayRandomly(N);

            for (int i = 0; i < N.Length; i++)
                Y[i] = N[i] * N[i];

            Console.WriteLine($"Массив N: {string.Join(" ", N)}");
            Console.WriteLine($"Массив Y: {string.Join(" ", Y)}");
        }

        private static void Task2()
        {
            int[] C = new int[15];

            FillArrayRandomly(C);

            int min = C[0];

            foreach (int element in C)
            {
                if (element < min && element % 2 != 0)
                    min = element;
            }

            Console.WriteLine($"Массив C: {string.Join(" ", C)}");
            Console.WriteLine($"C min: {min}");
        }

        private static void Task3()
        {
            int[,] A = new int[6, 6];
            int product = 1;
            int sum = 0;

            FillArrayRandomly(A);

            Console.WriteLine("Матрица A:");
            PrintArray(A);

            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (A[i, i] > 0)
                    product *= A[i, i];

                sum += A[i, A.GetLength(1) - 1 - i];
            }

            Console.WriteLine($"Произведение положительных элементов главной диагонали: {product}");
            Console.WriteLine($"Сумма всех элементов побочной диагонали: {sum}");
        }

        private static void Task4()
        {
            int[,] B = new int[7, 3];
            int negativeCount = 0;
            int sum = 0;

            FillArrayRandomly(B);

            Console.WriteLine("Матрица B:");
            PrintArray(B);

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    int element = B[i, j];

                    if (element > 0)
                        sum += element;
                    else if (element < 0)
                        negativeCount++;
                    else
                        B[i, j] = 1;
                }
            }

            Console.WriteLine($"Сумма всех положительных элементов: {sum}");
            Console.WriteLine($"Количество отрицательных элементов: {negativeCount}");

            Console.WriteLine("Матрица B после замены нулей на единицы:");
            PrintArray(B);
        }

        private static void Task5()
        {
            int[,] B = new int[6, 6];
            int rowsCount = B.GetLength(0);
            int columnsCount = B.GetLength(1);

            int[] X = new int[rowsCount * columnsCount / 2 - columnsCount];
            int elementsCount = 0;

            Console.Write("Введите K: ");
            int.TryParse(Console.ReadLine(), out int K);

            FillArrayRandomly(B);

            Console.WriteLine("Матрица B:");
            PrintArray(B);

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int element = B[i, j];

                    if (element <= K && element > i + j)
                        X[elementsCount++] = element;
                }
            }

            Array.Resize(ref X, elementsCount);
            Console.WriteLine($"Массив X: {string.Join(" ", X)}");
        }

        private static void Task6()
        {
            int[] X = new int[14];
            int[,] M = new int[5, 5];

            int[] C = new int[X.Length + M.GetLength(0) * M.GetLength(1)];
            int positiveCount = 0;

            FillArrayRandomly(X);
            Console.WriteLine($"Массив X: {string.Join(" ", X)}");

            FillArrayRandomly(M);
            Console.WriteLine("Матрица M:");
            PrintArray(M);

            foreach (int element in X)
            {
                if (element > 0)
                    C[positiveCount++] = element;
            }

            foreach (int element in M)
            {
                if (element > 0)
                    C[positiveCount++] = element;
            }

            Array.Resize(ref C, positiveCount);
            Array.Sort(C);

            Console.WriteLine($"Массив C: {string.Join(" ", C)}");
        }

        private static void FillArrayRandomly(int[] array)
        {
            const int MinValue = -9;
            const int MaxValue = 9;

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(MinValue, MaxValue + 1);
        }

        private static void FillArrayRandomly(int[,] array)
        {
            const int MinValue = -9;
            const int MaxValue = 9;

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = random.Next(MinValue, MaxValue + 1);
            }
        }

        private static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write($"{array[i, j]}\t");

                Console.WriteLine();
            }
        }
    }
}