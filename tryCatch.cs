/*
Write a program that prompts the user to enter a number. When the user enters a valid number, the program should display the square of that number.
If the user makes an invalid entry (such as entering a letter or symbol instead of a number), the program should display an error message: "Invalid entry! Please enter a number."
Note : A separete ReadME file is not created because it is a basic task.
  */

namespace ConsoleApp1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool isValidInput = false;
            while (!isValidInput)
            {
                try
                {
                    Console.Write("\n---\nEnter a number : ");
                    string input = Console.ReadLine();
                    int number = Convert.ToInt32(input);
                    Console.WriteLine($"Square of {number} is : {number * number}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid entry! Please enter a number.");
                }
                finally
                {
                    Console.WriteLine("Try Catch block is completed.");
                }
            }
        }
    }
}
