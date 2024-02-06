using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            HashSet<int> myHs = new HashSet<int>();   // Creating a HashSet

            
            myHs.Add(1);                   // Adding elements to the HashSet
            myHs.Add(2);
            myHs.Add(3);

         
            DisplayHashSet(myHs);                 // Displaying the elements in the HashSet

           
            int searchElement =1;               // Checking if an element is present
            Console.WriteLine($"Is {searchElement} present in the HashSet? {myHs.Contains(searchElement)}");

           
            myHs.Remove(3);     // Removing an element

            Console.WriteLine("\nHashSet after removing element 2:");   // Displaying the updated HashSet

            DisplayHashSet(myHs);

            myHs.Clear();      // Clearing the HashSet

           
            Console.WriteLine("\nIs the HashSet empty? " + (myHs.Count == 0));  // Checking if the HashSet is empty
        }

        static void DisplayHashSet(HashSet<int> hashSet)
        {
            Console.WriteLine("Elements in the HashSet:");
            foreach (var item in hashSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
 }


