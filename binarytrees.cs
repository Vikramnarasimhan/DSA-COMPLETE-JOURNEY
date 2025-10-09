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





}