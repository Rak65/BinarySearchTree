using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable<T>
    {
        public Node<T> root;    // Root node of the tree

        public BinarySearchTree()
        {
            root = null;
        }

        public void Add(T key)
        {
            root = AddRecursive(root, key);    // Call the recursive helper method to add a node
        }

        // Recursive helper method to add a node
        private Node<T> AddRecursive(Node<T> current, T key)
        {
            if (current == null)    // If the current node is null, create a new node with the key
                return new Node<T>(key);

            // Compare the key with the current node's key and recursively add the key to the appropriate subtree
            if (key.CompareTo(current.Key) < 0)
                current.Left = AddRecursive(current.Left, key);
            else if (key.CompareTo(current.Key) > 0)
                current.Right = AddRecursive(current.Right, key);

            return current;
        }
    }
}
