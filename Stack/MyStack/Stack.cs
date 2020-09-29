using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
    public class Stack<T>
    {
        public bool IsEmpty { get { return first == null; } }
        private Node<T> first;

        public void Push(T obj)
        {
            if (first == null)
                first = new Node<T>(obj);
            else
            {
                first = new Node<T>(obj, first);
            }
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new Exception("Stack is empty");
            else
            {
                T ell = first.Element;
                first = first.Next;
                return ell;
            }
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new Exception("Stack is empty");
            else
                return first.Element;
        }

        
    }

    public class Node<T>
    {
        public T Element { get; private set; }
        public Node<T> Next { get; set; }

        public Node(T element)
        {
            Element = element;
        }

        public Node(T element, Node<T> next)
            : this(element)
        {
            Next = next;
        }
    }
}
