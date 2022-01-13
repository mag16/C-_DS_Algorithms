using System;

/* 

Binary Search Tree is a node-based binary tree data structure which has the following properties:  

The left subtree of a node contains only nodes with keys lesser than the node’s key.
The right subtree of a node contains only nodes with keys greater than the node’s key.
The left and right subtree each must also be a binary search tree. 
There must be no duplicate nodes.


    BST will only work when storing a sortable data type (?)
    BST can search, access, insert, and delete data elements in logarithmic time O(log n)
    BST is much faster than an array at search, insert, and delete (O(log n) vs O(n))
    BST is slightly slower than an array at access (O(log n) vs O(1))
    BST’s main weakness is its tendency to become imbalanced if left unregulated by some self-balancing mechanism
*/
namespace BinarySearchTree {

    public class Node {
        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node (int value) {
            this.Value = value;
        }
    }

    public class BinarySearchTree {
        private Node _root;
        public BinarySearchTree () => _root = null;

        // This method mainly calls insertNode()
        public void Insert (int value) {
            if (_root == null) {
                _root = new Node (value);
                return;
            }

            InsertNode (_root, value);
        }
        //recursive method to insert a node.
        Node InsertNode (Node root, int value) {
            if (root == null) {
                root = new Node (value);
            }

            // Otherwise, recur down the tree 
            if (value < root.Value)
                root.Left = InsertNode (root.Left, value);
            else if (value > root.Value)
                root.Right = InsertNode (root.Right, value);

            // Return the (unchanged) node pointer 
            return root;
        }

        public static bool Contains (Node root, int value) {
            if (root == null)
                return false;
            if (root.Value == value)
                return true;
            if (value < root.Value)
                return Contains (root.Left, value);
            else
                return Contains (root.Right, value);

        }

        void DisplayTree() 
        {
            DisplayTree (_root);
        }

        static void DisplayTree (Node root) 
        {
            if (root != null)
                DisplayTree (root.Left);
                if(root.Left != null && root.Right != null)
                    Console.Write(root.Value + " ");
                DisplayTree(root.Right);
        }

        public static void Main (string[] args) {
            // Node n1 = new Node (1, null, null);
            // Node n3 = new Node (3, null, null);
            // Node n2 = new Node (2, n1, n3);

            // Console.WriteLine (Contains (n2, 3));

            BinarySearchTree tree = new BinarySearchTree ();
            //Node root = new Node(1,null,null);

            tree.Insert (4);
            tree.Insert (2);
            tree.Insert (5);
            tree.Insert (10);
            tree.Insert (3);
            Console.WriteLine(tree);
            tree.DisplayTree();
        }
    }
}