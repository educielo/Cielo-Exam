using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Right.Right = new Node(4);
            tree.Root.Left.Left = new Node(5);
            tree.Root.Left.Right.Right = new Node(6);
            Console.WriteLine("Height of tree is : " + tree.GetMaxDepth(tree.Root));
        }
    }
    public class Node
    {
        public int Data;
        public Node Left, Right;
        public Node(int item)
        {
            Data = item;
            Left = Right = null;
        }
    }
    public class Tree
    {
        public Node Root { get; set; }

        /* Compute the "maxDepth" of a tree -- the number of
        nodes along the longest path from the root node
        down to the farthest leaf node.*/
        public int GetMaxDepth(Node node)
        {
            if (node == null)
                return -1;
            else
            {
                /* compute the depth of each subtree */
                int lDepth = GetMaxDepth(node.Left);
                int rDepth = GetMaxDepth(node.Right);
                /* use the larger one */
                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }

    }
}
