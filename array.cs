/*
Tasks:
Define an array that will hold 10 integer values.
Fill the elements of this array using a for loop, then print them to the console using a foreach loop.
Add a new value, taken from the user, to this array as the 11th element.
Print the array elements in descending order.
*/

// Note: A separate README file is not used as all tasks are completed within a single file.

/*
Tasks:
Define an array that will hold 10 integer values.
Fill the elements of this array using a for loop, then print them to the console using a foreach loop.
Add a new value, taken from the user, to this array as the 11th element.
Print the array elements in descending order.
*/

// Note: A separate README file is not used as all tasks are completed within a single file.

using System.Collections.Immutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] myArr = new int[10]; // Creating array

            // Assigning values with a for loop
            for (int i = 0; i < myArr.Length; i++)
            {
                Random rnd = new Random(); //Assigning random number
                myArr[i] = rnd.Next(0, 100);
            }

            // Printing all the items in console
            foreach (int item in myArr)
            {
                Console.Write(item + " ");
            }
            
            // Resizing myArray because it was predefined as 10
            Array.Resize(ref myArr, 11); 
            Console.Write("\n\nPlease enter a number to add to the list : ");
            myArr[myArr.Length - 1] = Convert.ToInt32(Console.ReadLine());

            // Sorting in ascending order
            Array.Sort(myArr);
            // Sorting in descending order
            Array.Reverse(myArr);

            Console.WriteLine("\nArray sorted in descending order: ");
            foreach (int item in myArr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
