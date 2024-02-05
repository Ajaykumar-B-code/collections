using System;
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
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            list.Add(6);
            list.Insert(1, 7); // insert at any index(indexpositon,value)
            Console.WriteLine("Element at index 3: " + list[3]);
            Console.Write("Sliced elements from index 1 to 4: ");
            foreach (int element in list.GetRange(1, 4))
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            list.Remove(3); // remove the element from the list
            int poppedElement = list[1];
            list.RemoveAt(1); // remove the element at the index
            list.Clear(); // remove all the elements in the list
            list.Add(20); 
            list[0] = 20;

           
            List<int> anotherList = new List<int> { 7, 8, 9 };  // Concatenate lists
            List<int> combinedList = new List<int>(list);
            combinedList.AddRange(anotherList);

            Console.WriteLine("Combined List: " + string.Join(", ", combinedList));
            int length = combinedList.Count; // to get length of the list
            Console.WriteLine("Length of the Combined List: " + length);


            Console.WriteLine("Enter the number to check it is there in list or not");
            int numcheck = Convert.ToInt16(Console.ReadLine());


            bool elementPresent = combinedList.Contains(numcheck); // Search for an element in list
            Console.WriteLine($"Is {numcheck} present in the list? {elementPresent}");


            Console.WriteLine("Enter the number to check its index");
            int numindex = Convert.ToInt16(Console.ReadLine());
            int indexOf = combinedList.IndexOf(numindex);
            Console.WriteLine($"Index of {numindex} in the list at{indexOf}");


            combinedList.Sort(); // sort the list
            combinedList.Reverse(); // reverse the list
       
            Console.ReadLine();
        }
    }
}
