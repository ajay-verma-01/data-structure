using System;
using System.Collections.Generic;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.WriteLine("Binary Search 7");
            Console.WriteLine(BinarySearch(arr, 7));

            Console.WriteLine("Binary Search 11");
            Console.WriteLine(BinarySearch(arr, 11));

            Console.WriteLine("BinarySearchRecursive 7");
            Console.WriteLine(BinarySearchRecursive(arr, 7, 0, arr.Length -1));

            Console.WriteLine("BinarySearchRecursive 11");
            Console.WriteLine(BinarySearchRecursive(arr, 11, 0, arr.Length - 1));
        }

        public static int LinearSearch(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(int[] arr, int key)
        {
            var result = -1;

            int min = 0, max = arr.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (key == arr[mid])
                {
                    Console.WriteLine("Found Key: " + arr[mid]);
                    return arr[mid];
                }
                else if(key < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            Console.WriteLine("Key Not Found.");
            return result;
        }

        public static int BinarySearchRecursive(int[] arr, int key, int min, int max)
        {
            if (min > max)
            {
                Console.WriteLine("Key Not Found.");
                return -1;
            }

            int mid = (min + max) / 2;

            if (arr[mid] == key)
            {
                Console.WriteLine("Found Key: " + arr[mid]);
    
                return arr[mid];
            }
            else if (arr[mid] < key)
            {
                return BinarySearchRecursive(arr, key, mid + 1, max);
            }
            else
            {
                return BinarySearchRecursive(arr, key, min, mid - 1);
            }


        }

        public static void BFSBinaryTree(Node<int> rootNode, int searchedData)
        {
            var queue = new Queue<Node<int>>();
            queue.Enqueue(rootNode);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                if (currentNode.Data == searchedData)
                {
                    break;
                }

                if (currentNode.Left != null)
                    queue.Enqueue(currentNode.Left);

                if (currentNode.Right != null)
                    queue.Enqueue(currentNode.Right);
            }
        }
    }

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T item)
        {
            Data = item;
            Left = Right = null;
        }
    }
}
