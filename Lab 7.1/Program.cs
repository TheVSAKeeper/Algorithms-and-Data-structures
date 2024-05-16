using System;

namespace Lab_7._1
{
    internal static class Program
    {
        private static void Main()
        {
            int totalBooks = 10;
            int selectedBooks = 4;

            int ways = Combination(totalBooks, selectedBooks);
            Console.WriteLine($"Вы можете выбрать {selectedBooks} книги из {totalBooks} различных книг {ways} способами.");
        }

        private static int Factorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;

            return number * Factorial(number - 1);
        }

        private static int Combination(int totalBooks, int selectedBooks) =>
            Factorial(totalBooks) / (Factorial(selectedBooks) * Factorial(totalBooks - selectedBooks));
    }
}