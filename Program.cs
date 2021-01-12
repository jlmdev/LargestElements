using System;
using System.Collections.Generic;

namespace LargestElements
{

    class Program
    {
        public static List<int> Largest(int n, List<int> xs)
        {
            // Find the n highest elements in a list
            if (n == 0)
            {
                return new List<int>();
            }
            else
            {
                // Need to figure out comparison in C# List


                new List<int> sortedArray = xs.Sort()
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            Console.WriteLine(Largest(0, new List<int> { 1, 2, 3, 4, 5 }));
        }
    }
}
