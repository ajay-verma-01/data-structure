using System;
using System.Collections.Generic;
using System.Text;

namespace MyQueue
{
    public class Queue
    {
        private static int front, rear, capacity;
        private static int[] queue;

        public Queue(int c)
        {
            front = rear = 0;
            capacity = c;
            queue = new int[capacity];
        }

        // function to insert an element  
        // at the rear of the queue  
        public void queueEnqueue(int data)
        {
            // check queue is full or not  
            if (capacity == rear)
            {
                Console.Write("\nQueue is full\n");
                return;
            }

            // insert element at the rear  
            else
            {
                queue[rear] = data;
                rear++;
            }
            return;
        }

        // function to delete an element  
        // from the front of the queue  
        public void queueDequeue()
        {
            // if queue is empty  
            if (front == rear)
            {
                Console.Write("\nQueue is empty\n");
                return;
            }

            // shift all the elements from index 2 till rear  
            // to the right by one  
            else
            {
                for (int i = 0; i < rear - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }

                // store 0 at rear indicating there's no element  
                if (rear < capacity)
                    queue[rear] = 0;

                // decrement rear  
                rear--;
            }
            return;
        }

        // print queue elements  
        public void queueDisplay()
        {
            int i;
            if (front == rear)
            {
                Console.Write("\nQueue is Empty\n");
                return;
            }

            // traverse front to rear and print elements  
            for (i = front; i < rear; i++)
            {
                Console.Write(" {0} <-- ", queue[i]);
            }
            return;
        }

        // print front of queue  
        public void queueFront()
        {
            if (front == rear)
            {
                Console.Write("\nQueue is Empty\n");
                return;
            }
            Console.Write("\nFront Element is: {0}", queue[front]);
            return;
        }
    }
}
