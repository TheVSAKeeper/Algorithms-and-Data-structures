using System;

namespace Lab_7._2_17
{
    internal static class Program
    {
        public static void Main()
        {
            PerformTasks(Task2,
                Task4,
                Task6,
                Task8,
                Task10,
                Task12,
                Task14,
                Task16,
                Task18);
        }

        private static void PerformTasks(params Action[] tasks)
        {
            int taskNumber = 2;

            foreach (Action task in tasks)
            {
                Console.WriteLine($"\n\tЗадание {taskNumber}");
                task.Invoke();
                Console.WriteLine();

                taskNumber += 2;
            }
        }

        private static void Task2()
        {
            int baseNumber = 2;
            int exponent = 3;

            int power = Power(baseNumber, exponent);
            Console.WriteLine($"{baseNumber} в степени {exponent} равно {power}.");
        }

        private static int Power(int baseNumber, int exponent)
        {
            if (exponent == 0)
                return 1;

            return baseNumber * Power(baseNumber, exponent - 1);
        }

        private static void Task4()
        {
            int number = 42;
            int baseNumber = 2;

            string convertedNumber = ConvertToBase(number, baseNumber);
            Console.WriteLine($"Число {number} в {baseNumber}-ичной системе равно {convertedNumber}.");
        }

        private static string ConvertToBase(int number, int baseNumber)
        {
            if (number < 0 || baseNumber < 2 || baseNumber > 9)
                return "Неверные входные данные";

            if (number == 0)
                return "";

            return ConvertToBase(number / baseNumber, baseNumber) + number % baseNumber;
        }

        private static void Task6()
        {
            int firstTerm = 2;
            int difference = 3;
            int numberOfTerms = 4;

            int sumOfProgression = SumOfProgression(firstTerm, difference, numberOfTerms);

            Console.WriteLine($"Сумма {numberOfTerms} первых членов арифметической прогрессии " + $"с первым членом {firstTerm} и разностью {difference} равна {sumOfProgression}.");
        }

        private static int SumOfProgression(int firstTerm, int difference, int numberOfTerms)
        {
            if (numberOfTerms == 0)
                return 0;

            return SumOfProgression(firstTerm + difference, difference, numberOfTerms - 1) + firstTerm;
        }

        private static void Task8()
        {
            int[] array = { 5, 3, 7, 2, 9 };

            int minElement = MinElement(array);
            Console.WriteLine($"Минимальный элемент массива равен {minElement}.");
        }

        private static int MinElement(int[] array) => MinElement(array, 0);

        private static int MinElement(int[] array, int index)
        {
            if (array == null || array.Length == 0 || index < 0 || index >= array.Length)
                return int.MaxValue;

            if (index == array.Length - 1)
                return array[index];

            return Math.Min(array[index], MinElement(array, index + 1));
        }

        private static void Task10()
        {
            int a = 15;
            int b = 26;

            bool isCoprime = IsCoprime(a, b);
            Console.WriteLine($"Числа {a} и {b} {(isCoprime ? "являются" : "не являются")} взаимно простыми.");
        }

        private static bool IsCoprime(int a, int b)
        {
            if (a == 1 || b == 1)
                return true;

            if (a == b)
                return false;

            if (a > b)
                return IsCoprime(a - b, b);

            return IsCoprime(a, b - a);
        }

        private static void Task12()
        {
            int a = 24;
            int b = 36;

            int binaryGcd = BinaryGcd(a, b);
            Console.WriteLine($"НОД({a}, {b}) = {binaryGcd}");
        }

        private static int BinaryGcd(int a, int b)
        {
            if (a < 0 || b < 0)
                return -1;

            if (a == 0 || b == 0)
                return a + b;

            if (a == b)
                return a;

            if (a % 2 == 0 && b % 2 == 0)
                return 2 * BinaryGcd(a / 2, b / 2);

            if (a % 2 == 0)
                return BinaryGcd(a / 2, b);

            if (b % 2 == 0)
                return BinaryGcd(a, b / 2);

            if (a > b)
                return BinaryGcd((a - b) / 2, b);

            return BinaryGcd((b - a) / 2, a);
        }

        private static void Task14()
        {
            Task14_1();
            Task14_2();
            Task14_3();
        }

        private static void Task14_1()
        {
            double firstTerm = 5;
            double ratio = 7;
            int n = 3;

            double geometricProgressionTerm = GeometricProgressionTerm(firstTerm, ratio, n);

            Console.WriteLine($"n-й член геометрической прогрессии с первым членом {firstTerm} " + $"и знаменателем {ratio} равен {geometricProgressionTerm}.");
        }

        private static double GeometricProgressionTerm(double firstTerm, double ratio, int n)
        {
            if (n == 1)
                return firstTerm;

            return ratio * GeometricProgressionTerm(firstTerm, ratio, n - 1);
        }

        private static void Task14_2()
        {
            double firstTerm = 5;
            double ratio = 7;
            int n = 3;

            double sumOfProgression = GeometricProgressionSum(firstTerm, ratio, n);

            Console.WriteLine($"Сумма {n} первых членов геометрической прогрессии " + $"с первым членом {firstTerm} и знаменателем {ratio} равна {sumOfProgression}.");
        }

        private static double GeometricProgressionSum(double firstTerm, double ratio, int n)
        {
            if (n == 1)
                return firstTerm;

            return firstTerm + ratio * GeometricProgressionSum(firstTerm, ratio, n - 1);
        }

        private static void Task14_3()
        {
            double firstTerm = 5;
            double ratio = 7;

            int i = 5;
            int k = 7;

            double sumOfProgression = GeometricProgressionSumRange(firstTerm, ratio, i, k);

            Console.WriteLine($"Сумма членов с {i} по {k} геометрической прогрессии " + $"с первым членом {firstTerm} и знаменателем {ratio} равна {sumOfProgression}.");
        }

        private static double GeometricProgressionSumRange(double firstTerm, double ratio, int i, int k)
        {
            if (i == k)
                return GeometricProgressionTerm(firstTerm, ratio, i);

            return GeometricProgressionTerm(firstTerm, ratio, i) + GeometricProgressionSumRange(firstTerm, ratio, i + 1, k);
        }

        private static void Task16()
        {
            int[] array = { 5, 3, 7, 2, 9 };

            int minIndex = MinIndex(array);
            Console.WriteLine($"Индекс минимального элемента массива равен {minIndex}.");
        }

        private static int MinIndex(int[] array) => MinIndex(array, 0);

        private static int MinIndex(int[] array, int index)
        {
            if (array == null || array.Length == 0 || index < 0 || index >= array.Length)
                return -1;

            if (index == array.Length - 1)
                return index;

            int min = MinIndex(array, index + 1);

            if (array[index] < array[min])
                return index;

            return min;
        }

        private static void Task18()
        {
            int x = 48;
            int y = 18;

            int euclideanGcd = EuclideanGcd(x, y);
            Console.WriteLine($"НОД({x}, {y}) = {euclideanGcd}");
        }

        private static int EuclideanGcd(int x, int y)
        {
            if (x < 0 || y < 0)
                return -1;

            if (x == 0 || y == 0)
                return x + y;

            return EuclideanGcd(y, x % y);
        }
    }
}