using System;
using static System.Math;

namespace Lab_3._4._2
{
    internal static class Program
    {
        public static void Main()
        {
            Console.Write("Введите значение x: ");

            if (double.TryParse(Console.ReadLine(), out double x) == false)
            {
                Console.WriteLine("Ошибка");
                return;
            }

            Console.Write("Введите значение V: ");

            if (int.TryParse(Console.ReadLine(), out int V) == false)
            {
                Console.WriteLine("Ошибка");
                return;
            }

            double sum = 0.0;
            int n = 1;
            int factorial = 1;

            do
            {
                double an = 3 * n * x * Pow(3, n) / factorial;
                sum += an;
                factorial *= n;

                n++;
            } while (sum <= V);

            Console.WriteLine($"Номер элемента, после которого сумма({sum}) больше V({V}) - {n - 1}");
        }
    }
}