using System;
using static System.Math;

namespace Lab_3._4._1
{
    internal static class Program
    {
        private static void Main()
        {
            Console.Write("Введите значение x: ");

            if (double.TryParse(Console.ReadLine(), out double x) == false)
            {
                Console.WriteLine("Ошибка");
                return;
            }

            Console.Write("Введите значение эпсилон (10^..): ");

            if (int.TryParse(Console.ReadLine(), out int epsilonPow) == false)
            {
                Console.WriteLine("Ошибка");
                return;
            }

            double epsilon = Pow(10, epsilonPow);

            double sum = 0;
            double an = 1;
            int n = 0;
            int factorial = 1;

            while (an >= epsilon)
            {
                n++;

                factorial *= n;
                an = 3 * n * x * Pow(3, n) / factorial;
                sum += an;
            }

            Console.WriteLine($"Сумма элементов ряда S - {sum}");
        }
    }
}