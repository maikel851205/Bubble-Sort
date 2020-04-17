using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort // Complexity O(n^2)
{
    class MySort
    {
       
        static void Main(string[] args)
        {
            
            
            int[] arr = { 78, 55, 45, 98, 13 };

            int temp;

            for (int j = 0; j < arr.Length-1; j++)
            {
                for (int i  = 0; i < arr.Length-1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
            Console.WriteLine("sorted:");
            foreach (int p in arr)
                Console.Write(p + " "); // ***display in the same row***.
            Console.Read();

        }
    }
}

// QUICKSORT is the best sorting algorithm. is O(nlogn) in the best and in the 
// average case, and O(n^2) in the worst case.
//But because it has the best performance in the average case for most inputs,
//Quicksort is generally considered the “fastest” sorting algorithm. 
//At the end of the day though, whatever the best sorting algorithm really 
//is depends on the input (and who you ask).

