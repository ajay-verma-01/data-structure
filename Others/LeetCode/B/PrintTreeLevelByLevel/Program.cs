using System;
using System.Collections.Generic;

namespace PrintTreeLevelByLevel
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node left, right;
            public Node(int item)
            {
                data = item;
                left = right = null;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);

            PrintLevelOrder(root);
        }

        private static void PrintLevelOrder(Node root)
        {
            int height = GetHeight(root);

            for (int i = 1; i <=height; i++)
            {
                PrintGivenLevel(root, i);
            }
        }

        List<List<int>> result = new List<List<int>>();
        private static void PrintGivenLevel(Node root, int level)
        {
            if (root == null)
            {
                return;
            }
            if (level == 1)
            {
                Console.Write(root.data + " ");
            }
            else if(level > 1)
            {
                PrintGivenLevel(root.left, level - 1);
                PrintGivenLevel(root.right, level -1);
            }
        }

        private static int GetHeight(Node root)
        {
            if (root == null)
                return 0;

            return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
        }
    }
}
