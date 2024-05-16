using System;
using System.Diagnostics;

namespace Lab_2._2
{
    internal static class Program
    {
        public static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int positiveSum = 0;
            int negativeSum = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Введите {i + 1} число: ");
                int.TryParse(Console.ReadLine(), out int number);

                if (number > 0)
                    positiveSum += number;
                else
                    negativeSum += number;
            }

            stopwatch.Stop();

            Console.WriteLine($"+: {positiveSum}\n-: {negativeSum}\nElapsed Ticks: {stopwatch.ElapsedTicks}");
            Console.ReadKey();
        }
    }
}