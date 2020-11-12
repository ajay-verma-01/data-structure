using System;

namespace AddTwoNumberLinkedList
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // creating first list 
            var head1 = new ListNode(2);
            head1.next = new ListNode(4);
            head1.next.next = new ListNode(3);
           

            // creating seconnd list 
            var head2 = new ListNode(5);
            head2.next = new ListNode(6);
            head2.next.next = new ListNode(4);

            var result = AddTwoNumbers(head1, head2);
            while (result != null)
            {
                Console.Write(result.val);
                result = result.next;
            }
            //Console.WriteLine(result.val);

            Console.ReadKey();
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode tempHead = new ListNode();
            ListNode curr = tempHead;
            int carry = 0;
            while (l1!=null || l2!= null)
            {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;

                int sum = carry + x + y;
                carry = sum / 10;

                curr.next = new ListNode(sum % 10);
                curr = curr.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;

            }

            if (carry > 0)
                curr.next = new ListNode(carry);

            return tempHead.next;
        }
    }
}
