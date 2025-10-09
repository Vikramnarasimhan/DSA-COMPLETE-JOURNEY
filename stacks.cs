using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Generic;
class Stacks {
    static void Main() {
        Stack<int> stacks = new Stack<int>();
        stacks.Push(1); 
        stacks.Push(2); 
        stacks.Push(3);
        Console.WriteLine(stacks.Count);
        stacks.Pop();
        Console.WriteLine(stacks.Count);
        stacks.Push(4); 
        stacks.Push(5);
      

    
    }



}