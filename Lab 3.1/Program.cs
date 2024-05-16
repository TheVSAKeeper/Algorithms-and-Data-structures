using System;
using static System.Math;

namespace Lab_3._1
{
    internal static class Program
    {
        public static void Main()
        {
            const int A = 1;
            const int B = 6;
            const double H = 0.25;

            for (double x = A; x <= B; x += H)
            {
                double y = Sqrt(x * Pow(x - 3, 4));

                Console.WriteLine($"X = {x}: Y = {y}");
            }
        }
    }
}