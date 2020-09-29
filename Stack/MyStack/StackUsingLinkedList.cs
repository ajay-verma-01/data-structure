using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
    public class Node
    { 
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int item)
        {
            Data = item;
            Next = null;    
        }
    }
    public class StackUsingLinkedList
    {
        public Node Top { get; set; }

        public StackUsingLinkedList()
        {
            Top = null;
        }

        public void Push(int item)
        {
            var newNode = new Node(item);

            if (Top == null)
            {
                newNode.Next = null;
            }
            else
            {
                newNode.Next = Top;
                
            }
            Top = newNode;
        }

        public int Pop()
        {
            if (Top == null)
            {
                throw new IndexOutOfRangeException("Stack is empty.");
            }
            else
            {
                int val = Top.Data;
                Top = Top.Next;
                return val;
            }
        }

        public void Peek()
        {
            if (Top == null)
            {
                Console.WriteLine("Stack Underflow.");
                return;
            }
            Console.WriteLine("{0} is on the top of Stack", Top.Data);
        }

    }
}
