using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Generic;
public class BinaryTree {
    public class Node {
        public int Data;
        public Node Left;
        public Node Right;
        public Node(int data) {
            Data = data;
            Left = null;
            Right = null;

        
        }
    }
    private Node root;
    public BinaryTree() { 
    root=null;
    
    }
    public void insert(int data) {
        root = insertrecord(root,data);
    
    }
    private Node insertrecord(Node current,int data) {
        if (current == null) {
            return new Node(data);
        
        }
        if (current.Data > data)
        {
           current.Left= insertrecord(current.Left, data);
        }
        else {

            current.Right= insertrecord(current.Right, data);
        }
        return current;

    
    
    }

    //inorder traversal ascending order wise displayed
    public void Inordertraversal() {
        Console.WriteLine("Printing inorder traversal: LEFT-ROOT-RIGHT");
        inorderrec(root);
        Console.WriteLine();   //helps move my pointer to the next line

    
    
    }
    
    
    
    private void inorderrec(Node current) {
        if (current!=null) {
            inorderrec(current.Left);
            Console.WriteLine(current.Data + "");
            inorderrec(current.Right);

        
        }
    
    }

    //preorder traversal starts from root goes left and then goes right
    public void preordertraversal() {
        Console.WriteLine("Printing pre order traversal: ROOT-LEFT-RIGHT ");
        preorderrec(root);
        Console.WriteLine();
    }
    private void preorderrec(Node current) {
        if (current!=null) {
            Console.WriteLine(current.Data + "");
            preorderrec(current.Left);
            preorderrec(current.Right);
        }
    }

    //post order first children then parents left to right
    public void postordertraversal() {
        Console.WriteLine("Printing post order traversal");

    
    
    }
    private void postorderrec(Node current) {
        if (current != null) {
            postorderrec(current.Left);
            postorderrec(current.Right);
            Console.WriteLine(current.Data+ " ");

        
        }
    
    }



}