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
            Stack st = new Stack();          // Creating a Stack

            st.Push(1);            // Push elements onto the Stack
            st.Push(2);
            st.Push(3);

            Display(st);                     // Displaying the elements in the 

            Console.WriteLine("Top element: " + st.Peek());  // Peek at the top element

            Console.WriteLine("After removeing the single element");
            st.Pop();                         //to pop the single element from the top
            Display(st);
            while (st.Count > 0)              // Pop all the elements
            {
                Console.WriteLine("Pop: " + st.Pop());
            }

            Console.WriteLine("Is the Stack empty? " + (st.Count == 0));  // Check if the Stack is empty
        }

        static void Display(Stack stack)
        {
            Console.WriteLine("Elements in the Stack:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
}
