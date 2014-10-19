using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16PrintAllLeafNodes
{
    //class BST
    //{
    // Creating Binary Search Tree node class
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int value)
        {
            this.data = value;
            left = null;
            right = null;
        }
    }
    public class BinarySearchTree
    {
        public Node root;
        static int count;
        public BinarySearchTree()
        {
            root = null;
        }

        //Creates and returns a BST node
        public Node addNode(int data)
        {
            Node temp = new Node(data);
            if (root == null)
            {
                root = temp;
            }
            count++;
            return temp;
        }

        //Procedure inserts 'newNode' in BST at proper position
        public void insert(Node root, Node newNode)
        {
            while (root != null)
            {
                if (newNode.data > root.data)
                {
                    if (root.right == null)
                    {
                        root.right = newNode;
                        break;
                    }
                    root = root.right;
                }
                else
                {
                    if (root.left == null)
                    {
                        root.left = newNode;
                        break;
                    }
                    root = root.left;
                }
            }
        }            // Recursive Procedure travels BST tree Inorder Fassion
        public void inOrder(Node root)
        {
            //Node temp = root;
            //if (temp == null)
            //{
            //    return;
            //}
            //else 
            if (root != null)
            {
                inOrder(root.left);
                Console.Write(root.data + " ");
                inOrder(root.right);
            }
            else
            {
                return;
            }
        }

        public void printLeaves(Node temp)
        {
            if (temp == null)
            {
                return;
            }
            if (temp.left == null && temp.right == null)
            {
                System.Console.Write(temp.data + " ");
            }
            else
            {
                printLeaves(temp.left);
                printLeaves(temp.right);
            }
        }
    }
    //}
}
