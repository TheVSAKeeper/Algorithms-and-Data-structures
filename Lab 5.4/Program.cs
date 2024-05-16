using System;
using System.Collections.Generic;

namespace Lab_5._4
{
    internal static class Program
    {
        private static void Main()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine($"Размер стека: {stack.Count}");
            Console.WriteLine($"Извлечено из стека: {stack.Pop()}");
            Console.WriteLine($"Размер стека: {stack.Count}");

            Console.WriteLine($"На верху стека: {stack.Peek()}");
            Console.WriteLine($"Элементы стека: {string.Join(" ", stack)}");

            Console.WriteLine();

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine($"Размер очереди: {queue.Count}");
            Console.WriteLine($"Извлечено из очереди: {queue.Dequeue()}");
            Console.WriteLine($"Размер очереди: {queue.Count}");

            Console.WriteLine($"В начале очереди: {queue.Peek()}");
            Console.WriteLine($"Элементы очереди: {string.Join(" ", queue)}");
        }
    }
}