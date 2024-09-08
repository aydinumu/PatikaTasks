//  Task Description:
//  - Create a list containing 10 random integers.
//  - Perform the following LINQ queries on the list and print the results to the console:
//      1. Even numbers
//      2. Odd numbers
//      3. Negative numbers
//      4. Positive numbers
//      5. Numbers greater than 15 and less than 22
//      6. The square of each number (This requires creating a new list to display the squared numbers)

//   A Separated ReadMe file is not created because tasks are explained here.


namespace ConsoleApp1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Creating List
            List<int> numbers = new List<int>();
          
            Random rnd = new Random();      
            // Adding random numbers to the list
            for (int i = 0; i < 10; i++) { numbers.Add(rnd.Next(-50, 50)); }

            Console.Write("My Generated Numbers : ");
            Console.WriteLine(string.Join(", ", numbers));

            // Even numbers
            Console.Write("\nEven Numbers         : ");
            Console.WriteLine(string.Join(", ", numbers.Where(x => x % 2 == 0)));

            // Odd Numbers
            Console.Write("\nOdd Numbers          : ");
            Console.WriteLine(string.Join(", ", numbers.Where(x => x % 2 != 0)));

            // Negative Numbers
            Console.Write("\nNegative Numbers     : ");
            Console.WriteLine(string.Join(", ", numbers.Where(x => x < 0)));

            // Positive Numbers
            Console.Write("\nPositive Numbers     : ");
            Console.WriteLine(string.Join(", ", numbers.Where(x => x > 0)));

            // Numbers between 15-22
            Console.Write("\nBetween 15 &  22     : ");
            Console.WriteLine(string.Join(", ", numbers.Where(x => x > 15 && x < 22)));

            Console.Write("\nMy Generated Numbers : ");
            Console.WriteLine(string.Join(", ", numbers));

            Console.Write("\nSquare of Each Number: ");
            // Square of each number
            var squaredList = numbers.Select(num => num * num).ToList();
            Console.WriteLine(string.Join(", ", squaredList));

            Console.WriteLine("\n\nHave a nice day day !");
        }
    }
}
