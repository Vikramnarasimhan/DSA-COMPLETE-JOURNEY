using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Generic;

class searchingalgos {
  //  int[] arr = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
    static void Main() {
//jump search find the block where the target would belong to and then iterate within that loop prev keeps track of the beginning number of the block and step or n marke the end of block
        int[] arr = {  1,2,3,4,5,6,7,8,9 };
        foreach (int i in arr) { 
        Console.WriteLine($"{i}");
        
        }
        int target = 4;
        int n = arr.Length;
        int step = (int)Math.Floor(Math.Sqrt(n));
        int prev = 0;
        while (arr[Math.Min(step, n) - 1] < target) {

            prev = step;
            step += (int)Math.Floor(Math.Sqrt(n));
            if (prev >= n) {
                Console.WriteLine("number does not exist");
            }
        }
        for (int i = prev; i < Math.Min(step, n); i++) {
            if (arr[i]==target) {
                Console.WriteLine($"{i}");
            
            }
        
        }




    }




}