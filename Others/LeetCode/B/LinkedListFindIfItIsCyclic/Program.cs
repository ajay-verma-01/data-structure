using System;
using System.Collections.Generic;

namespace LinkedListFindIfItIsCyclic
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;

            ListNode slow = head;
            ListNode fast = head.next;

            while (slow != fast)
            {
                if (fast == null || fast.next == null)
                    return false;

                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }

        public bool hasCycle1(ListNode head)
        {
            HashSet<ListNode> nodesSeen = new HashSet<ListNode>();
            while (head != null)
            {
                if (nodesSeen.Contains(head))
                {
                    return true;
                }
                else
                {
                    nodesSeen.Add(head);
                }
                head = head.next;
            }
            return false;
        }
    }
}
