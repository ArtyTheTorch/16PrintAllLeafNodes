using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16PrintAllLeafNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            
            // Inserting Nodes to Binary search Tree
           
            bst.insert(bst.root, bst.addNode(21));
            bst.insert(bst.root, bst.addNode(19));
            bst.insert(bst.root, bst.addNode(7));
            bst.insert(bst.root, bst.addNode(18));
            bst.insert(bst.root, bst.addNode(20));
            bst.insert(bst.root, bst.addNode(13));
            bst.insert(bst.root, bst.addNode(8));
            bst.insert(bst.root, bst.addNode(22));

            // Traversing BST in Inorder fashion
            bst.inOrder(bst.root);
            System.Console.WriteLine();
            bst.printLeaves(bst.root);

            Console.ReadKey();
        }
    }
}
