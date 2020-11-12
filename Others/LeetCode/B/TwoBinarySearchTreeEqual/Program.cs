using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TwoBinarySearchTreeEqual
{
    class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

     
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var root1 = new TreeNode(1);
            root1.left = new TreeNode(2);
            root1.right = new TreeNode(3);
            root1.left.left = new TreeNode(4);
            root1.left.right = new TreeNode(5);

            var root2 = new TreeNode(1);
            root2.left = new TreeNode(2);
            root2.right = new TreeNode(3);
            root2.left.left = new TreeNode(4);
            root2.left.right = new TreeNode(5);

            Console.WriteLine(IsSameTree(root1, root2));
            Console.WriteLine(IsSameTree2(root1, root2));

            Console.ReadKey();

        }

        public static bool IsSameTree(TreeNode n1, TreeNode n2)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(n1);
            q.Enqueue(n2);

            while (q.Count != 0)
            {
                var tempNode1 = q.Dequeue();
                var tempNode2 = q.Dequeue();

                if (tempNode1 == null && tempNode2 == null)
                    continue;

                if (tempNode1 == null || tempNode2 == null)
                    return false;
                if (tempNode1.val != tempNode2.val)
                    return false;

                q.Enqueue(tempNode1.left);
                q.Enqueue(tempNode2.left);
                q.Enqueue(tempNode1.right);
                q.Enqueue(tempNode2.right);
            }

            return true;
        }

        public static bool IsSameTree2(TreeNode a, TreeNode b)
        {
            if (a == null && b == null)
                return true;

            if (a != null && b != null)
            {
                return (a.val == b.val) && IsSameTree2(a.left, b.left) && IsSameTree2(a.right, b.right);
            }

            return false;
        }
    }
}
