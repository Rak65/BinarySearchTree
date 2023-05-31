using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node<T> where T : IComparable<T>
    {
        public T Key { get; }            // Key value of the node
        public Node<T> Left { get; set; }    // Reference to the left child node
        public Node<T> Right { get; set; }   // Reference to the right child node

        public Node(T key)
        {
            Key = key;
            Left = null;
            Right = null;
        }
    }
}
