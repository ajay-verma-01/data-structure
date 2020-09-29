using System;
using System.Collections.Generic;
using System.Text;

namespace DLinkedList
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }

        public Node()
        {
            Data = default(T);
            Next = null;
            Prev = null;
        }
        public Node(T item)
        {
            Data = item;
            Next = null;
            Prev = null;
        }


    }
    public class DLinkedList<T>
    {
        public Node<T> FirstNode { get; set; }
        public Node<T> LastNode { get; set; }

        public int Length { get; set; }

        public DLinkedList()
        {
            FirstNode = null;
            LastNode = null;
            Length = 0;
        }

        public void Prepend(T item)
        {
            var newNode = new Node<T>(item);

            if (FirstNode == null)
            {
                FirstNode = LastNode = newNode;
            }
            else {
                newNode.Next = FirstNode;
                FirstNode.Prev = newNode;
                FirstNode = newNode;
            }
            Length++;
        }

        public void Append(T item)
        {
            var newNode = new Node<T>(item);

            if (FirstNode == null)
            {
                FirstNode = LastNode = newNode;
            }
            else
            {
                LastNode.Next = newNode;
                newNode.Prev = LastNode;
                LastNode = newNode;
            }
            Length++;
        }

        public void InsertAt(T item, int index)
        {
            if (index == 0)
            {
                Prepend(item);
            }
            else if (index == Length)
            {
                Append(item);
            }

            else if (index > 0 && index < Length)
            {
                var newNode = new Node<T>(item);

                var current = FirstNode;

                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }

                newNode.Prev = current;
                newNode.Next = current.Next;
                current.Next = newNode;

                Length++;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Length)
                throw new IndexOutOfRangeException();


            if (index == 0)
            {
                FirstNode = FirstNode.Next;
                FirstNode.Prev = null;
            }
            else if (index == Length - 1)
            {
                LastNode = LastNode.Prev;
                LastNode.Next = null;
            }
            else
            {
                var current = FirstNode;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                var temp = current; 
                current.Next = current.Next.Next;
                current.Next.Prev = temp;

            }
            Length--;
        }

        public Node<T> GetAt(int index)
        {
            if (index == 0)
                return FirstNode;
            else if (index == Length - 1)
                return LastNode;
            else if (index > 0 && index < Length - 1)
            {
                var current = FirstNode;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                return current;
            }
            else
                throw new IndexOutOfRangeException();
        }
    }
}
