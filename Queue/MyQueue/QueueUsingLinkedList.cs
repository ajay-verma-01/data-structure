using System;
using System.Collections.Generic;
using System.Text;

namespace MyQueue
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
    public class QueueUsingLinkedList
    {
        public Node Rear { get; set; }
        public Node Front { get; set; }

        public QueueUsingLinkedList()
        {
            Front = Rear = null;
        }

        public void Enqueue(int item)
        {
            var newNode = new Node(item);

            if (Rear == null)
            {
                Front = Rear = newNode;
            }
            else
            {
                Rear.Next = newNode;
                Rear = newNode;
            }
        }

        public int Dequeue()
        {
            if (Rear == null)
                throw new IndexOutOfRangeException("Queue is empty.");
            else
            {
                var value = Front.Data;
                Front = Front.Next;

                if (Front == null)
                    Rear = null;

                return value;
            }

            
        }
    }
}
