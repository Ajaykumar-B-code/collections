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
            Queue myQ = new Queue();    // Creating a Queue

            myQ.Enqueue("1");      // Enqueue elements
            myQ.Enqueue("2");
            myQ.Enqueue("3");

            DisplayQueue(myQ);            // Displaying the elements in the Queue

            Console.WriteLine("Front element: " + myQ.Peek());   // Peek at the front element

            while (myQ.Count > 0)    // Dequeue elements
            {
                Console.WriteLine("Dequeue: " + myQ.Dequeue());
            }

           
            Console.WriteLine("Is the Queue empty? " + (myQ.Count == 0));    // Check if the Queue is empty
        }

        static void DisplayQueue(Queue queue)
        {
            Console.WriteLine("Elements in the Queue:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    
}
