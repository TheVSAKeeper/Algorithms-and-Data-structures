using System;

namespace Lab_3._2
{
    internal static class Program
    {
        public static void Main()
        {
            const int RowsCount = 10;
            const double CentimetreInInch = 2.54;

            Console.WriteLine("Inch\t|Cm\t|");

            for (int i = 0; i < RowsCount; i++)
            {
                int inch = i + 1;
                double centimeters = inch * CentimetreInInch;

                Console.WriteLine($"{inch}\t|{centimeters}\t|");
            }
        }
    }
}