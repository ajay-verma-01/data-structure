using System;

namespace BSTIsValid
{
    public class Program
    {
        public class Node
        {
            public int data;
            public Node left, right;

            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node root = newNode(3);
            root.left = newNode(2);
            root.right = newNode(5);
            root.left.left = newNode(1);
            root.left.right = newNode(4);

            if (isBST(root, null, null))
                Console.Write("Is BST");
            else
                Console.Write("Not a BST");

            Console.ReadKey();
        }

        public static bool isBST(Node root, Node l, Node r)
        {
            if (root == null)
                return true;

            if (l != null && root.data <= l.data)
                return false;

            if (r != null && root.data >= r.data)
                return false;

            return isBST(root.left, l, root) && isBST(root.right, root, r);
        }

        public static Node newNode(int data)
        {
            Node node = new Node(data);
            return (node);
        }

        static bool isBSTUtil(Node root, int prev)
        {
            // traverse the tree in inorder fashion and 
            // keep track of prev node 
            if (root != null)
            {
                if (!isBSTUtil(root.left, prev))
                    return false;

                // Allows only distinct valued nodes 
                if (root.data <= prev)
                    return false;

                // Initialize prev to current 
                prev = root.data;

                return isBSTUtil(root.right, prev);
            }

            return true;
        }

    }
}
