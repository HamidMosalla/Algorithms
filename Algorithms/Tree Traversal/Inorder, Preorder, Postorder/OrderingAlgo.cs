using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tree_Traversal.Inorder__Preorder__Postorder
{
    internal class OrderingAlgo
    {
        public class Node
        {
            public int data;
            public Node left, right;
        }

        public static void Inorder(Node node)
        {
            if (node == null)
                return;

            Inorder(node.left);
            Console.Write(node.data + " ");
            Inorder(node.right);
        }

        public static void Preorder(Node node)
        {
            if (node == null)
                return;

            Console.Write(node.data + " ");
            Preorder(node.left);
            Preorder(node.right);
        }

        public static void Postorder(Node node)
        {
            if (node == null)
                return;

            Postorder(node.left);
            Postorder(node.right);
            Console.Write(node.data + " ");
        }

    }
}
