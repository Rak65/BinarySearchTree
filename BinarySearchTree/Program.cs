using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();    // Create an instance of the binary search tree

            bst.Add(56);    // Add root node with key 56
            bst.Add(30);    // Add node with key 30 as left child of 56
            bst.Add(70);    // Add node with key 70 as right child of 56

            // Print the tree structure for visualization
            PrintTree(bst.root);

            Console.WriteLine("BST creation completed.");
        }
        // Helper method to print the tree structure
        static void PrintTree<T>(Node<T> node) where T : IComparable<T>
        {
            if (node == null)
                return;

            PrintTree(node.Left);    // Recursively print the left subtree

            Console.WriteLine(node.Key);    // Print the key value of the node

            PrintTree(node.Right);    // Recursively print the right subtree
        }
    }
}
