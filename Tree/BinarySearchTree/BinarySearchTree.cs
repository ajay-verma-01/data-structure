using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;

namespace BinarySearchTree
{
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
    public class BinarySearchTree<T>
    {
        public Node<T> Root { get; set; }

        public BinarySearchTree()
        { 
            
        }

        public void Insert(T item)
        {
            var newNode = new Node<T>(item);

            if(Root == null)
                Root = newNode;
            else
            {
                var current = Root;
                while (true)
                {
                    if (Comparer<T>.Default.Compare(current.Data, newNode.Data) > 0)
                    {
                        if (current.Left == null)
                        {
                            current.Left = newNode;
                            break;
                        }
                        current = current.Left;
                    }
                    else
                    {
                        if (current.Right == null)
                        {
                            current.Right = newNode;
                            break;
                        }
                        current = current.Right;
                    }
                }
            }
        }

        /*
        Binary Search Tree | Set 2 (Delete)
        When we delete a node, three possibilities arise.
        1) Node to be deleted is leaf: Simply remove from the tree.

                      50                            50
                   /     \         delete(20)      /   \
                  30      70       --------->    30     70 
                 /  \    /  \                     \    /  \ 
               20   40  60   80                   40  60   80
        2) Node to be deleted has only one child: Copy the child to the node and delete the child

                      50                            50
                   /     \         delete(30)      /   \
                  30      70       --------->    40     70 
                    \    /  \                          /  \ 
                    40  60   80                       60   80
        3) Node to be deleted has two children: Find inorder successor of the node. 
        Copy contents of the inorder successor to the node and delete the inorder successor. 
        Note that inorder predecessor can also be used.

                      50                            60
                   /     \         delete(50)      /   \
                  40      70       --------->    40    70 
                         /  \                            \ 
                        60   80                           80
        The important thing to note is, inorder successor is needed only when right child is not empty. 
        In this particular case, 
        inorder successor can be obtained by finding the minimum value in right child of the node.

        				10
					/           \
				9					11
			/						\
			3						18	
			\						/
			6						15
										
										
										
										
            3 6 9 10 11 15 18
                 */

        public Node<T> Delete(Node<T> rootNode, T item)
        {
            var delNode = new Node<T>(item);

            /* Base Case: If the tree is empty */
            if (rootNode == null) return null;

            /* Otherwise, recur down the tree */
            if (Comparer<T>.Default.Compare(rootNode.Data, item) > 0)
            {
                rootNode.Left = Delete(rootNode.Left, item);
            }
            else if (Comparer<T>.Default.Compare(rootNode.Data, item) < 0)
            {
                rootNode.Right = Delete(rootNode.Right, item);
            }
            // if key is same as root's key, then This is the node  
            // to be deleted  
            else
            {
                // node with no child  
                if (rootNode.Left == null && rootNode.Right == null)
                {
                    rootNode = null;
                }
                //Node with Right child
                else if (rootNode.Left == null)
                {
                    rootNode = rootNode.Right;
                }
                //Node with Left child
                else if (rootNode.Right == null)
                {
                    rootNode = rootNode.Left;
                }
                // node with two children: Get the inorder successor (smallest in the right subtree)  
                else
                {
                    var minValue = FindMinNode(rootNode.Right);

                    rootNode = minValue;
                    rootNode = Delete(rootNode.Right, item);
                }

            }

            return rootNode;
        }

        public Node<T> Delete_V2(Node<T> rootNode, T item)
        {
            /* Base Case: If the tree is empty */
            if (rootNode == null) return null;

            while (rootNode != null)
            {
                /* Otherwise, recur down the tree */
                if (Comparer<T>.Default.Compare(rootNode.Data, item) > 0)
                {
                    rootNode = rootNode.Left;
                }
                else if (Comparer<T>.Default.Compare(rootNode.Data, item) < 0)
                {
                    rootNode = rootNode.Right;
                }
                // if key is same as root's key, then This is the node  
                // to be deleted  
                else
                {
                    // node with no child  
                    if (rootNode.Left == null && rootNode.Right == null)
                    {
                        rootNode = null;
                    }
                    //Node with Right child
                    else if (rootNode.Left == null)
                    {
                        rootNode = rootNode.Right;
                    }
                    //Node with Left child
                    else if (rootNode.Right == null)
                    {
                        rootNode = rootNode.Left;
                    }
                    // node with two children: Get the inorder successor (smallest in the right subtree)  
                    else
                    {
                        var minValue = FindMinNode(rootNode.Right);

                        rootNode.Data = minValue.Data;
                        rootNode.Right = minValue.Right;
                        //rootNode = rootNode.Right;
                    }

                }
            }

            return rootNode;
        }

        
        public T FindMin(Node<T> node)
        {
            var current = node;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current.Data;
        }

        public Node<T> FindMinNode(Node<T> node)
        {
            var current = node;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }

        public T FindMax(Node<T> node)
        {
            T result = default(T);
            var current = node;
            while (current.Right != null)
            {
                current = current.Right;
            }
            result = current.Data;
            return result;
        }

        public Node<T> Find(T key)
        {
            var current = Root;
            while(current != null)
            {
                if (Comparer<T>.Default.Compare(current.Data, key) > 0)
                    current = current.Left;
                else if (Comparer<T>.Default.Compare(current.Data, key) < 0)
                    current = current.Right;
                else if (Comparer<T>.Default.Compare(current.Data, key) == 0)
                {
                    break;
                }
                else
                {
                    current = null;
                }
            }

            return current;
        }

        //LEFT-ROOT-RIGHT
        public void PrintInOrderRec(Node<T> node)
        {
            if (node == null)
                return;

            PrintInOrderRec(node.Left);

            Console.Write(node.Data + "   ");

            PrintInOrderRec(node.Right);
        }

        //ROOT-LEFT-RIGHT
        public void PrintPreOrderRec(Node<T> node)
        {
            if (node == null)
                return;

            Console.Write(node.Data + "   ");
            PrintPreOrderRec(node.Left);
            PrintPreOrderRec(node.Right);
        }

        //LEFT-RIGHT-ROOT
        public void PrintPostOrderRec(Node<T> node)
        {
            if (node == null)
                return;

            PrintPostOrderRec(node.Left);
            PrintPostOrderRec(node.Right);
            Console.Write(node.Data + "   ");

        }

        /*
         
            1) Create an empty stack S.
            2) Initialize current node as root
            3) Push the current node to S and set current = current->left until current is NULL
            4) If current is NULL and stack is not empty then 
                 a) Pop the top item from stack.
                 b) Print the popped item, set current = popped_item->right 
                 c) Go to step 3.
            5) If current is NULL and stack is empty then we are done.
         */
        public void InOrderTraverseStack(Node<T> node)
        {
            var stack = new Stack<Node<T>>();
            var current = node;

            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }

                var top = stack.Pop();
                Console.Write(top.Data + "   ");
                current = top.Right;
            }
        }

        /*
         sing Morris Traversal, we can traverse the tree without using stack and recursion.
        The idea of Morris Traversal is based on Threaded Binary Tree. In this traversal, 
        we first create links to Inorder successor and print the data using these links, 
        and finally revert the changes to restore original tree.

        1. Initialize current as root 
        2. While current is not NULL
           If the current does not have left child
              a) Print current’s data
              b) Go to the right, i.e., current = current->right
           Else
              a) Make current as the right child of the rightmost 
                 node in current's left subtree
              b) Go to this left child, i.e., current = current->left



        Although the tree is modified through the traversal, it is reverted back to its original shape 
        after the completion. Unlike Stack based traversal, no extra space is required for this traversal.

        filter_none
         */

        public void InOrderTraverseMorris(Node<T> root)
        {
            Node<T> current, pre;

            if (root == null)
                return;

            current = root;
            while (current != null)
            {
                if (current.Left == null)
                {
                    Console.Write(current.Data + "   ");
                    current = current.Right;
                }
                else
                {
                    /* Find the inorder predecessor of current */
                    pre = current.Left;
                    while (pre.Right != null && pre.Right != current)
                        pre = pre.Right;

                    /* Make current as right child  
                    of its inorder predecessor */
                    if (pre.Right == null)
                    {
                        pre.Right = current;
                        current = current.Left;
                    }

                    /* Revert the changes made in  
                    if part to restore the original  
                    tree i.e., fix the right child  
                    of predecssor*/
                    else
                    {
                        pre.Right = null;
                        Console.Write(current.Data + " ");
                        current = current.Right;
                    } /* End of if condition pre->right == NULL */

                } /* End of if condition current->left == NULL*/

            } /* End of while */
        }
    }
}
