using System;
using System.Collections.Generic;
using static MinDepthBST.Program.BST;

namespace MinDepthBST
{
    class Program
    {
        public static int count = 0;
        public static Node root;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            BST bST = new BST();
            root = new Node(3);
            root.left = new Node(9);
            root.right = new Node(20);
            root.right.left= new Node(15);
            root.right.right = new Node(7);

            Console.WriteLine(bST.MinDepth(root));
            Console.WriteLine(bST.MaxDepth(root));
            Console.ReadLine();
        }
        public class BST
        {
            public class Node
            {
                public int key;
                public Node left;
                public Node right;

                public Node()
                {
                }

                public Node(int item)
                {
                    key = item;
                    left = null;
                    right = null;
                }


            }

            public BST()
            {
                root = null;
            }
            //public Node Add(int item)
            //{
            //    root = InsertItem(root, item);
            //    return root;
            //}
            //public Node InsertItem(Node root, int item)
            //{
            //    if (root == null)
            //    {
            //        root = new Node(item);
            //        return root;
            //    }
            //    else
            //    {
            //        if (item < root.key)
            //        {
            //            root.left = InsertItem(root.left, item);
            //        }
            //        if (item >= root.key)
            //        {
            //            root.right = InsertItem(root.right, item);
            //        }
            //    }
            //    return root;
            //}
            public int MinDepth(Node root)
            {
                if (root == null)
                    return 0;
                int minleft = MinDepth(root.left);
                int minright = MinDepth(root.right);
                return 1 + Math.Min(minleft, minright);
            }

            public int MaxDepth(Node root)
            {
                if (root == null)
                    return 0;
                int minleft = MinDepth(root.left);
                int minright = MinDepth(root.right);
                return 1 + Math.Max(minleft, minright);
            }

        }
    }
}
