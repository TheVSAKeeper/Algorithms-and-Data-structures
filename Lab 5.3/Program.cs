using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_5._3
{
    internal static class Program
    {
        public static void Main()
        {
            PerformTasks(Task1, Task2, Task3);
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
            List<double> list = new List<double>();
            list.Insert(0, 1);
            list.Insert(0, 2);
            list.Insert(0, 3);

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(4);
            linkedList.AddFirst(5);
            linkedList.AddFirst(6);

            Console.WriteLine($"Линейный список: {string.Join(" ", list)}");
            Console.WriteLine($"Линейный связанный список: {string.Join(" ", linkedList)}");

            Console.WriteLine("а) Проверка, является ли список пустым");
            Console.WriteLine($"Список пустой: {IsEmpty(list)}");

            Console.WriteLine("б) Нахождение среднего арифметического элементов списка");
            Console.WriteLine($"Среднее арифметическое элементов списка: {GetAverage(list)}");

            Console.WriteLine("в) Замена всех вхождений E1 на E2");

            int e1 = 4;
            int e2 = 1;
            ReplaceElements(linkedList, e1, e2);

            Console.WriteLine($"Список после замены {e1} на {e2}: {string.Join(", ", linkedList)}");

            Console.WriteLine("д) Проверка, упорядочены ли элементы списка");
            Console.WriteLine($"Список упорядочен: {IsListOrdered(list)}");

            Console.WriteLine("е) Нахождение суммы последнего и предпоследнего элементов");
            Console.WriteLine($"Сумма последнего и предпоследнего элементов: {SumOfLastTwoElements(linkedList)}");
        }

        private static void Task2()
        {
            LinkedList<int> L1 = new LinkedList<int>();
            L1.AddFirst(6);
            L1.AddFirst(7);
            L1.AddFirst(8);
            Console.WriteLine($"Список L1: {string.Join(", ", L1)}");

            LinkedList<int> L2 = new LinkedList<int>();
            L2.AddFirst(6);
            L2.AddFirst(9);
            L2.AddFirst(10);
            Console.WriteLine($"Список L2: {string.Join(", ", L2)}");

            Console.WriteLine($"Список L (удовлетворяющие условию (входят хотя бы в один из списков L1 и L2)): {string.Join(", ", Union(L1, L2))}");

            Console.WriteLine($"Список L (удовлетворяющие условию (входят в список L1, но не входят в список L2)): {string.Join(", ", Difference(L1, L2))}");
        }

        private static void Task3()
        {
            List<double> L1 = new List<double> { 1.1, 2.2, 4.4, 6.6, 8.8 };
            List<double> L2 = new List<double> { 2.2, 3.3, 5.5, 7.7, 9.9 };

            List<double> L = MergeSortedLists(L1, L2);

            Console.WriteLine($"Упорядоченный по неубыванию список L: {string.Join(" ", L)}");
        }

        private static bool IsEmpty(List<double> list) => list.Count == 0;

        private static double GetAverage(List<double> list)
        {
            if (IsEmpty(list))
            {
                Console.WriteLine("Список не может быть пустым.");
                return 0.0;
            }

            double sum = list.Sum();

            return sum / list.Count;
        }

        private static void ReplaceElements(LinkedList<int> list, int e1, int e2)
        {
            LinkedListNode<int> currentNode = list.First;

            while (currentNode != null)
            {
                if (currentNode.Value == e1)
                    currentNode.Value = e2;

                currentNode = currentNode.Next;
            }
        }

        private static bool IsListOrdered(List<double> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < list[i - 1])
                    return false;
            }

            return true;
        }

        private static int SumOfLastTwoElements(LinkedList<int> list)
        {
            if (list.Count < 2)
            {
                Console.WriteLine("Список содержит менее двух элементов.");
                return 0;
            }

            LinkedListNode<int> lastNode = list.Last;
            LinkedListNode<int> secondLastNode = lastNode.Previous;

            return lastNode.Value + secondLastNode.Value;
        }

        private static LinkedList<int> Union(LinkedList<int> firstList, LinkedList<int> secondList)
        {
            LinkedList<int> result = new LinkedList<int>(firstList);

            foreach (int item in secondList.Where(item => result.Contains(item) == false))
                result.AddLast(item);

            return result;
        }

        private static LinkedList<int> Difference(LinkedList<int> firstList, LinkedList<int> secondList)
        {
            LinkedList<int> result = new LinkedList<int>();

            foreach (int element in firstList.Where(element => secondList.Contains(element) == false))
                result.AddLast(element);

            return result;
        }

        private static List<double> MergeSortedLists(List<double> firstList, List<double> secondList)
        {
            List<double> result = new List<double>(firstList);

            result.AddRange(secondList);
            result.Sort();

            return result;
        }
    }
}