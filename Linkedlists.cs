using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using static Linked;
//only minute difference between circular linked list and normal linked list is that the tail instead of pointing to null points to head
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
            head.next = head;

        }
        else
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;

            }
            current.next = newnode;
          //  newnode.next = head or null depending on linear or circular linked list;

        }


    }
    public void delete(int data) { 
    if(head==null){
        Console.WriteLine("The linked list is empty nothing is there to delete");

        
        }
        if (head.Data == data)
        {
            head = head.next;


        }
        else
        {
            Node current = head;
            while (current.next != null && current.next.Data != data)
            {
                current = current.next;

            }
            if (current.next == null)
            {

                Console.WriteLine("The node to be deleted does not exist");
            }
            else
            {

                current.next = current.next.next;
            }
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
            list.delete(20);
            list.printlinkedlist();
            list.adddata(20);
            list.printlinkedlist();
            list.delete(10);
            list.printlinkedlist();
    }


}





public class DoublyLinkedList
{
    private Node head;

    // Insert at the end
    public void Insert(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
        newNode.Prev = current;
    }

    // Display forward
    public void DisplayForward()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    // Display backward
    public void DisplayBackward()
    {
        Node current = head;
        if (current == null) return;

        // Move to the last node
        while (current.Next != null)
        {
            current = current.Next;
        }

        // Traverse backward
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Prev;
        }
        Console.WriteLine();
    }
}







//Node current = head;
//do
//{
//  Console.WriteLine(current.data);
//  current = current.next;
//} while (current != head);

















