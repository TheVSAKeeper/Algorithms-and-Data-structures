using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_5._5
{
    internal static class Program
    {
        public static void Main()
        {
            Deque<int> deque = new Deque<int>();

            deque.AddFirst(1);
            deque.AddLast(2);
            deque.AddFirst(3);

            Console.WriteLine($"Дек: {string.Join(" ", deque)}");

            Console.WriteLine($"Первый элемент: {deque.First}");
            Console.WriteLine($"Последний элемент: {deque.Last}");

            Console.WriteLine($"Извлеченный первый элемент: {deque.RemoveFirst()}");
            Console.WriteLine($"Извлеченный последний элемент: {deque.RemoveLast()}");

            Console.WriteLine($"Количество элементов в деке: {deque.Count}");
        }
    }

    public class Deque<T> : IEnumerable<T>
    {
        private DoublyNode<T> _head;
        private DoublyNode<T> _tail;

        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();

                return _head.Data;
            }
        }

        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();

                return _tail.Data;
            }
        }

        public int Count { get; private set; }

        public bool IsEmpty => Count == 0;

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoublyNode<T> current = _head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public void AddLast(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                _tail.Next = node;
                node.Previous = _tail;
            }

            _tail = node;
            Count++;
        }

        public void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = _head;
            node.Next = temp;
            _head = node;

            if (Count == 0)
                _tail = _head;
            else
                temp.Previous = node;

            Count++;
        }

        public T RemoveFirst()
        {
            if (Count == 0)
                throw new InvalidOperationException();

            T output = _head.Data;

            if (Count == 1)
            {
                _head = _tail = null;
            }
            else
            {
                _head = _head.Next;
                _head.Previous = null;
            }

            Count--;
            return output;
        }

        public T RemoveLast()
        {
            if (Count == 0)
                throw new InvalidOperationException();

            T output = _tail.Data;

            if (Count == 1)
            {
                _head = _tail = null;
            }
            else
            {
                _tail = _tail.Previous;
                _tail.Next = null;
            }

            Count--;
            return output;
        }

        public class DoublyNode<TU>
        {
            public DoublyNode(TU data)
            {
                Data = data;
            }

            public TU Data { get; }
            public DoublyNode<TU> Previous { get; set; }
            public DoublyNode<TU> Next { get; set; }
        }
    }
}