using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace CheckForSymmetricBinaryTree
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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TreeNode root = new TreeNode(1);

            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(3);

            Console.WriteLine(IsSymmetric(root));

            Console.WriteLine(IsSymmetricRec(root));

            Console.ReadKey();
        }

        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            Queue<TreeNode> q = new Queue<TreeNode>();

            q.Enqueue(root.left);
            q.Enqueue(root.right);

            while (q.Count != 0)
            {
                var tempLeft = q.Dequeue();
                var tempRight = q.Dequeue();

                if (tempLeft == null && tempRight == null)
                    continue;

                if ((tempLeft == null && tempRight != null) ||
                    (tempLeft != null && tempRight == null))
                    return false;

                if (tempLeft.val != tempRight.val)
                    return false;

                q.Enqueue(tempLeft.left);
                q.Enqueue(tempRight.right);
                q.Enqueue(tempLeft.right);
                q.Enqueue(tempRight.left);
            }

            return true;
        }

        public static bool IsSymmetricRec(TreeNode root)
        {
            return isMirror(root, root);
        }

        private static bool isMirror(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null)
                return true;

            if (node1 != null && node2 != null && node1.val == node2.val)
                return (isMirror(node1.left, node2.right) && isMirror(node1.right, node2.left));

            return false;
        }
    }
}
