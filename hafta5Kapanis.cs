// README
// This program manages a list of cars with specific attributes including:
// - Production Date, Serial Number, Brand, Model, Color, Door Count
// Program Flow:
// 1. Prompts the user to decide if they want to add a car.
//    - Respond with 'Y' (yes) to add a car or 'N' (no) to finish.
//    - Invalid responses prompt the user to enter 'Y' or 'N' again.
// 2. If the user chooses to add a car:
//    - A new car object is created.
//    - The user is prompted to enter details for the car.
//    - The production date is automatically set to the current date.
//    - The door count is validated to ensure it's a numeric value. If invalid, the user is prompted to enter it again.
// 3. If the user chooses to finish:
//    - The program displays all cars in the list with their attributes.

// Note: This README summary is included in the code as no separate README file was created.

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the Car List Program !\n"); //Welcome

            List<Car> carList = new List<Car>(); //List to store car objects

            string answer = String.Empty;
            while (answer != "n")
            {
                Console.Write("Do you want to add a car ? ( Y / N ) : ");
                answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    Console.WriteLine("Great, I have some questions !");
                    // Create a new car object and add it to the list
                    Car car = new Car();
                    carList.Add(car);
                    Console.WriteLine($"{car.Brand} {car.Model} is created !\n----");
                }
                else if (answer == "n") { Console.WriteLine("\n\nThank you for participating.\n-----\nHere is the list of your cars :"); }
                else { Console.WriteLine("Please type 'Y' or 'N' \n"); } // Inform user of invalid input
            }

            foreach (Car car in carList) // Display all cars in the list
            {
                Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Color: {car.Color}, Serial Number: {car.SerialNumber}, Door Number: {car.Door}");
            }
        }

        public class Car
        {
            // Properties of the Car class
            public DateTime ProductionDate { get; set; }

            public string SerialNumber { get; set; }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Door { get; set; }

            // Constructor to initialize car properties
            public Car()
            {
                ProductionDate = DateTime.Now; // Set the production date to current date
                Console.Write("Brand of the Car : ");
                Brand = Console.ReadLine();
                Console.Write("Model of the Car : ");
                Model = Console.ReadLine();
                Console.Write("Color of the Car : ");
                Color = Console.ReadLine();
                Console.Write("Serial Number of the Car : ");
                SerialNumber = Console.ReadLine();
                isValidDoor(); // Validate the door number
            }

            // Method to validate door number input
            public void isValidDoor()
            {
            tryAgain:
                try
                {
                    Console.Write("Door number of the Car : ");
                    string input = Console.ReadLine();
                    int number = Convert.ToInt32(input);
                    Door = number; // Set the door number if valid
                }
                catch (FormatException ex)
                {
                    // Inform user of invalid input and prompt to try again
                    Console.WriteLine("I think you did a mistake, please try again, ");
                    goto tryAgain; // Retry input
                }
            }
        }
    }
}
