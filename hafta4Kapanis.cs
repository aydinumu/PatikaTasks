/*  This program simulates the registration process for electronic devices in a technology store, focusing on Phones and Computers. 
    It uses object-oriented principles such as inheritance, encapsulation, polymorphism, and abstraction. 
    The main flow allows the user to create either a Phone or a Computer, input their details, and then print the device information to the console.

    NOTE: There is no separate README file because all instructions and comments are provided within the code.  */


namespace ConsoleApp1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string userInput = "y";
            while (userInput != "q") // Creating a loop to control program flow
            {
                Console.WriteLine("\nPress '1' to submit Phone, Press '2' to submit Computer, Press 'Q' to quit program,");
                Console.Write("( 1 / 2 / Q ) : ");
                userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "1":
                        {
                            BaseMachine phone = new Phone(); // Creating a phone with user selection
                            Console.WriteLine("---");
                            phone.PrintInfo(); // Printing phone details
                            Console.WriteLine("---");
                            break;
                        }
                    case "2":
                        {
                            BaseMachine computer = new Computer(); // Creating a computer with user selection
                            Console.WriteLine("---");
                            computer.PrintInfo(); // Printing computer details
                            Console.WriteLine("---");
                            break;
                        }
                    case "q": Console.WriteLine("\nThank you, have a nice day!"); break; // Exit condition
                    default: Console.WriteLine("\nUnvalid input, please try again"); break;
                }
            }
        }
    }

    public abstract class BaseMachine
    {
        public DateTime productionDate { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperationSystem { get; set; }

        public BaseMachine()
        {
            productionDate = DateTime.Now; //Setting production date when object is created
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Production Date : {productionDate}");
            Console.WriteLine($"Serial Number : {SerialNumber}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Operation System : {OperationSystem}");
        }

        public abstract void PrintProductName(); // Abstract method to be implemented by derived classes
    }

    public class Phone : BaseMachine
    {
        public bool Licance { get; set; } // Different property from Base Class

        public Phone() // Constructor to get info with user input when created
        {
            Console.Write("Phone Name : ");
            Name = Console.ReadLine();
            Console.Write("Phone Description : ");
            Description = Console.ReadLine();
            Console.Write("Operation System: ");
            OperationSystem = Console.ReadLine();
            Console.Write("Serial Number : ");
            SerialNumber = Console.ReadLine();
            Console.Write("TR Licance? (Y/N) : ");
            Licance = Console.ReadLine().ToLower() == "y";
        }

        public override void PrintInfo()
        {
            base.PrintInfo(); // Print base info
            Console.WriteLine($"TR Licance : {Licance}"); // Print additional info
        }

        public override void PrintProductName()
        {
            Console.WriteLine($"Phone Name --> {Name}"); // Never used in console but it's in the tasks.
        }
    }

    public class Computer : BaseMachine
    {
        public int UsbPort { get; set; }
        public bool Bluetooth { get; set; }

        public Computer() // Constructor to get info with user input when created
        {
            Console.Write("Computer Name : ");
            Name = Console.ReadLine();
            Console.Write("Computer Description : ");
            Description = Console.ReadLine();
            Console.Write("Operation System: ");
            OperationSystem = Console.ReadLine();
            Console.Write("Serial Number : ");
            SerialNumber = Console.ReadLine();
            Console.WriteLine("Number of USB Port (2/4) : ");

            // USB Port assignment with validation
            if (int.TryParse(Console.ReadLine(), out int usbPort) && (usbPort == 2 || usbPort == 4))
            {
                UsbPort = usbPort;
            }
            else
            {
                Console.WriteLine("Invalid input or number, assigned to -1");
                UsbPort = -1;
            }
            Console.WriteLine("Bluetooth? (Y/N) : ");
            Bluetooth = Console.ReadLine().ToLower() == "y";
        }

        public override void PrintProductName()
        {
            Console.WriteLine($"Computer Name --> {Name}"); // Never used in console but it's in the tasks.
        }

        public override void PrintInfo()
        {
            base.PrintInfo();  // Print base info
            Console.WriteLine($"Usb Port : {UsbPort}"); // Print additional info
            Console.WriteLine($"Bluetooth : {Bluetooth}"); // Print additional info
        }
    }
}
