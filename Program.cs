// Author: Morgan Jones
// Date: 9/17/19
//Project: Creating an Array.
using System;

namespace Deliverable_3__Arrays
{
    class Program
    {
        static void Main(string[] args)
            // creating an auto populated array
        {
            int[] array = new int[25];

            for (int i = 0; i < 25; i++)
            {
                array[i] = i + 1;
            }
            // To display the array
            foreach (int number in array)
            {
                int i = number;
                Console.WriteLine("Element Value = {1}", i, number);
            }
            // To close the program
            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey(true);
            }
} // Close
    } 

    
    
        
