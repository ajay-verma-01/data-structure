using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var bst = new BinarySearchTree<int>();

            bst.Insert(10);
            Console.WriteLine("\nAfter Inserting 10");
            bst.PrintInOrderRec(bst.Root);

            bst.Insert(9);
            Console.WriteLine("\nAfter Inserting 9");
            bst.PrintInOrderRec(bst.Root);

            bst.Insert(11);
            Console.WriteLine("\nAfter Inserting 11");
            bst.PrintInOrderRec(bst.Root);

            bst.Insert(3);
            Console.WriteLine("\nAfter Inserting 3");
            bst.PrintInOrderRec(bst.Root);

            bst.Insert(18);
            Console.WriteLine("\nAfter Inserting 18");
            bst.PrintInOrderRec(bst.Root);

            bst.Insert(6);
            Console.WriteLine("\nAfter Inserting 6");
            bst.PrintInOrderRec(bst.Root);

            bst.Insert(15);
            Console.WriteLine("\nAfter Inserting 15");
            bst.PrintInOrderRec(bst.Root);

            var delNode = bst.Delete_V2(bst.Root, 10);
            Console.WriteLine("\nAfter Deleting 10");
            bst.PrintInOrderRec(bst.Root);

            var max = bst.FindMax(bst.Root);
            Console.WriteLine("\nAfter FindMax");
            Console.WriteLine(max);

            var find18 = bst.Find(18);
            Console.WriteLine("\nAfter Find 18");
            Console.WriteLine(find18.Data);

            var find20 = bst.Find(20);
            Console.WriteLine("\nAfter Find 20");
            Console.WriteLine(find18);

            Console.WriteLine("\nInOrderTraverseStack");
            bst.InOrderTraverseStack(bst.Root);

            Console.WriteLine("\nInOrderTraverse Morris");
            bst.InOrderTraverseMorris(bst.Root);

        }
    }
}
