using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Generic;
class Recursion {
    int factorial(n) {
        if (n == 0) {
            return 1;
        
        }
        return n * factorial(n-1);

        
    
    
    }
    static void Main()
    {

        Console.WriteLine($"{factorial(5)}");

    }



}
