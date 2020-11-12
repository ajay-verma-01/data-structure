using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.IO.Pipes;

namespace LCAInBinaryTree
{

    class Program
    {
        static TreeNode ans;
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode parent;
            public TreeNode(int x) { val = x; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /*Algorithm
        Start traversing the tree from the root node.
        If the current node itself is one of p or q, we would mark a variable mid as True and continue the search for the other node in the left and right branches.
        If either of the left or the right branch returns True, this means one of the two nodes was found below.
        If at any point in the traversal, any two of the three flags left, right or mid become True, this means we have found the lowest common ancestor for the nodes p and q.
        Let us look at a sample tree and we search for the lowest common ancestor of two nodes 9 and 11 in the tree.
        */
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            recurrseTree(root, p, q);
            return ans;
        }

        public static bool recurrseTree(TreeNode currentNode, TreeNode p, TreeNode q)
        {
            if (currentNode == null)
                return false;

            int left = recurrseTree(currentNode.left, p, q) ? 1 : 0;
            int right = recurrseTree(currentNode.right, p, q) ? 1 : 0;

            int mid = (currentNode == p || currentNode == q) ? 1 : 0;

            if (mid + left + right >= 2)
            {
                ans = currentNode;
            }

            return (mid + left + right) > 0;
        }

        public static TreeNode lowestCommonAncestorIterative(TreeNode root, TreeNode p, TreeNode q)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();

            Dictionary<TreeNode, TreeNode> parent = new Dictionary<TreeNode, TreeNode>();
            parent.Add(root, null);
            stack.Push(root);

            while (!parent.ContainsKey(p) || !parent.ContainsKey(q))
            {
                var node = stack.Pop();

                if (node.left != null) {
                    parent.Add(node.left, node);
                    stack.Push(node.left);
                }

                if (node.right != null)
                {
                    parent.Add(node.right, node);
                    stack.Push(node.right);
                }

            }

            HashSet<TreeNode> ancestors = new HashSet<TreeNode>();
            while (p!= null)
            {
                ancestors.Add(p);
                p = parent[p];
            }

            while (!ancestors.Contains(q))
            {
                q = parent[q];
            }
            return q;

        }


        public static TreeNode LCA(TreeNode p, TreeNode q)
        {
            Dictionary<TreeNode, bool> ancestors = new Dictionary<TreeNode, bool>();

            while (p != null)
            {
                ancestors.Add(p, true);
                p = p.parent;
            }

            while (q != null)
            {
                if (ancestors.ContainsKey(q))
                    return q;
                q = q.parent;
            }

            return null;
        }

    }
}
