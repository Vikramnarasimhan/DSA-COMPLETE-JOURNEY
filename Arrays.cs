using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
class Arrays {
    static void Main()
    {
        //ARRAY CREATION 1D
        int[] numbers = { 5, 4, 3, 2, 1,10,12,8,6,4,7,9,25 };
        //for (int i = numbers.Length - 1; i >= 0; i--) {
          //  Console.WriteLine(numbers[i]);
        //}
      //  foreach (int i in numbers) {

        //    Console.WriteLine(i);
        //}

        //BUBBLE SORT 
        Console.WriteLine("BUBBLE SORTING MY ARRAY");
            int n = numbers.Length ;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (numbers[j] > numbers[j + 1]) {
                    int dummy= numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = dummy;
                
                }
            
            }
        
        }
        // Console.WriteLine(numbers);
        Console.WriteLine(string.Join(", ", numbers));

        Console.WriteLine("enter element to be searched");
        int target = int.Parse(Console.ReadLine());
      //  for (int i = 0; i < n; i++)
        //{

          //  if (numbers[i] == target)
            //{
              //  Console.WriteLine($"The index of the target element using linear search is {i}");


//            }
  //      }
        int start = 0;
        int end = numbers.Length - 1;
        while (start<=end) {
        
        int mid=(start+end)/2;
            if (numbers[mid] == target) {
                Console.WriteLine($"The index of target element using binary search is {mid}");
                
            
            }
            if (target < numbers[mid])
            {
                end = mid - 1;

            }
            else {
                start = mid + 1;
            }
            
        
        }
        // Creating a jagged array
        //int[][] jagged = new int[3][];
        //jagged[0] = new int[] { 1, 2 };
        //jagged[1] = new int[] { 3, 4, 5 };
        //jagged[2] = new int[] { 6 };

        //// Iterating through it
        //for (int i = 0; i < jagged.length; i++)
        //{
        //    for (int j = 0; j < jagged[i].length; j++)
        //    {
        //        System.out.print(jagged[i][j] + " ");
        //    }
        //    System.out.println();
        //}














        //MATRIX CREATION (2-D ARRAY)
        //int[,] matrix = {
        //  {1,2,3 }
        //,{4,5,6}
        //,{7,8,9,} };
        //for (int i = 0; i < matrix.GetLength(0); i++) {
        //  for (int j = 0; j < matrix.GetLength(1); j++) { 
        //        Console.Write(matrix[i,j]+ " ");

        //}
        //Console.WriteLine();


        //KEY TAKEAWAY IS GETTING LENGTH .GetLength
    }


}