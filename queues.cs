using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Generic;


class queues {
    static void Main() {
        Queue<int> Myqueue = new Queue<int>();
        Myqueue.Enqueue(10);
        Myqueue.Enqueue(20);
        Myqueue.Enqueue(30);
        Myqueue.Enqueue(40);
       
       // foreach(int eachitem in Myqueue) {
         //   Console.WriteLine(eachitem);
        
        //}
        Console.WriteLine("Removing first item from queue and then displaying", Myqueue.Dequeue());
        
        foreach (int eachitem in Myqueue)
        {
            if (eachitem==Myqueue.Peek()) {
                Console.WriteLine($"first item after performing dequeue once: {eachitem}");
            
            }

        }
    }
  



}