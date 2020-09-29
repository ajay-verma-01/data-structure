using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;

namespace SLinkedList
{

    public class Node<T> : IComparable<Node<T>> where T : IComparable<T>
    { 
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node()
        {   
            Next = null;
            Data = default(T);
        }

        public Node(T item)
        {
            Next = null;
            Data = item;
        }

        public int CompareTo([AllowNull] Node<T> other)
        {
            if (other == null) return -1;

            return this.Data.CompareTo(other.Data);
        }
    }



    public class LinkedList<T> : IEnumerable<T> where T : IComparable<T>
    {
        public Node<T> FirstNode { get; set; }
        public Node<T> LastNode { get; set; }
        public int Count { get; set; }


        public LinkedList()
        {
            FirstNode = null;
            LastNode = null;
            Count = 0;
        }

        public void Prepend(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (FirstNode == null)
            {
                FirstNode = LastNode = newNode;
            }
            else
            {
                newNode.Next = FirstNode;
                FirstNode = newNode;
            }
            Count++;
        }

        public void Append(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (FirstNode == null)
            {
                FirstNode = LastNode = newNode;
            }
            else
            {
                LastNode.Next = newNode;
                LastNode = newNode;
            }
            Count++;
        }

        public void InsertAt(T item, int index) 
        {
            if (index == 0)
            {
                Prepend(item);
            }
            else if (index == Count)
            {
                Append(item);
            }

            else if (index > 0 && index < Count)
            {
                var newNode = new Node<T>(item);
                var current = FirstNode;

                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next;
                current.Next = newNode;
                Count++;
            }
            else {
                throw new IndexOutOfRangeException();
            }
            
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();


            if (index == 0)
            {
                FirstNode = FirstNode.Next;
            }
            else if (index == Count - 1)
            {
                var current = FirstNode;
                while (current.Next != null && current.Next != LastNode)
                {
                    current = current.Next;
                }

                current.Next = null;
                LastNode = current;
            }
            else
            {
                var current = FirstNode;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }

                current.Next = current.Next.Next;

            }
            Count--;


        }

        public Node<T> GetAt(int index)
        {
            if (index == 0)
                return FirstNode;
            else if (index == Count - 1)
                return LastNode;
            else if (index > 0 && index < Count -1)
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

        public void Reverse() 
        {

            /*
            Runtime complexity #
            The runtime complexity of this solution is linear, O(n)O(n), as we can reverse the linked list in a single pass.

            Memory complexity #
            The runtime complexity of this solution is constant, O(1)O(1), as no extra memory is required for the iterative solution.

            Let’s see how the solution works:

            If the linked list only contains 0 or 1 nodes, then the current list can be returned as it is. If there are two or more nodes, then the iterative solution starts with two pointers:

            reversed_list: A pointer to already reversed linked list (initialized to head).
            list_to_do: A pointer to the remaining list (initialized to head->next).
            We then set the reversed_list->next to NULL. This becomes the last node in the reversed linked list. reversed_list will always point to the head of the newly reversed linked list.

            At each iteration, the list_to_do pointer moves forward (until it reaches NULL). The current node becomes the head of the new reversed linked list and starts pointing to the previous head of the reversed linked list.

            The loop terminates when list_to_do becomes NULL, and the reversed_list pointer is pointing to the new head at the termination of the loop.

            Let’s reverse the linked list using the iterative approach:
             
             */
            /*
            if (Count == 0 || Count == 1)
                return;

            var reverse = FirstNode;
            var list_to_do = FirstNode.Next;
            reverse.Next = null;

            while (list_to_do != null)
            {
                var temp = list_to_do;
                list_to_do = list_to_do.Next;

                temp.Next = reverse;
                reverse = temp;
            }

            FirstNode = reverse;

        */



            /*
             
             Initialize three pointers prev as NULL, curr as head and next as NULL.
                Iterate trough the linked list. In loop, do following.
                // Before changing next of current,
                // store next node
                next = curr->next
                // Now change next of current
                // This is where actual reversing happens
                curr->next = prev

                // Move prev and curr one step forward
                prev = curr
                curr = next
             */


            Node<T> prev = null, current = FirstNode, next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;

                prev = current;
                current = next;
            }
            FirstNode = prev;
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //public class LinkedListEnumerator : IEnumerator<T>
        //{
        //    private Node<T> _current;
        //    private LinkedList<T> _doublyLinkedList;

        //    public LinkedListEnumerator(LinkedList<T> list)
        //    {
        //        this._doublyLinkedList = list;
        //        this._current = list.FirstNode;
        //    }

        //    public T Current
        //    {
        //        get { return this._current.Data; }
        //    }

        //    object System.Collections.IEnumerator.Current
        //    {
        //        get { return Current; }
        //    }

        //    public bool MoveNext()
        //    {
        //        _current = _current.Next;

        //        return (this._current != null);
        //    }

        //    public void Reset()
        //    {
        //        _current = _doublyLinkedList.FirstNode;
        //    }

        //    public void Dispose()
        //    {
        //        _current = null;
        //        _doublyLinkedList = null;
        //    }
        //}
    }


}
