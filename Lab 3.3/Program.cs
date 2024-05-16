using System;

namespace Lab_3._3
{
    internal static class Program
    {
        public static void Main()
        {
            Console.Write("Введите номер месяца: ");

            if (int.TryParse(Console.ReadLine(), out int monthNumber) == false)
            {
                Console.WriteLine("Ошибка");
                return;
            }

            const int MonthsInYear = 12;
            const int MonthsInSeason = 3;

            int seasonIndex = monthNumber % MonthsInYear / MonthsInSeason;
            string seasonName;

            if (seasonIndex == 0)
                seasonName = "Зима";
            else if (seasonIndex == 1)
                seasonName = "Весна";
            else if (seasonIndex == 2)
                seasonName = "Лето";
            else if (seasonIndex == 3)
                seasonName = "Осень";
            else
                seasonName = "Неизвестно";

            Console.WriteLine($"{monthNumber} - {seasonName}");
        }
    }
}