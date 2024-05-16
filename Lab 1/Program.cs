using System;
using static System.Math;

namespace Lab_1
{
    internal static class Program
    {
        public static void Main()
        {
            double a = 2;
            double b = 0.5;

            Console.Write("Введите x: ");
            double.TryParse(Console.ReadLine(), out double x);

            double Y = (x + a) * (Atan(x) - Sqrt(Abs(Pow(x - a, 3)) + Log(x * x * x + 1)));
            double F = Sin(x) - Exp(-a * x) + Log(Abs(x + a) + 2);

            Console.WriteLine($"x = {x}: Y = {Y}, F = {F}");
            Console.ReadKey();
        }
    }
}