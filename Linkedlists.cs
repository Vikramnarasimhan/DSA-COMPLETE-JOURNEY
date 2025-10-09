using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Generic;
//class LinkedList {
public class Linked
{





    public class Node
    {
        public int Data;
        public Node next;


        public Node(int data)
        {
            Data = data;
            next = null;

        }
    }
    private Node head;
    public void adddata(int data) {
        Node newnode = new Node(data);
        if (head == null)
        {
            head = newnode;

        }
        else
        {
            Node current = head;

            while (current.next != null)
            {
                current = current.next;

            }
            current.next = newnode;
        }


    }
    public void printlinkedlist() {
        Node current = head;
        while (current != null) {
            Console.Write(current.Data + "->");
            current = current.next;
        }
        Console.WriteLine("null");



    }






       static void Main(string[] args)
        {
            Linked list = new Linked();
            list.adddata(10);
            list.adddata(20);
            list.adddata(30);
            list.printlinkedlist(); // Output: 10 -> 20 -> 30 -> null
        }


}




        





    
        
        
        
        
        
        
        
        

    













