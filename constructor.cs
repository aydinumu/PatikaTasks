//Task list on this example
//Define a Baby class with properties: Birth Date, Name, Surname.
//Create two constructors:
  //1. Default constructor with no parameters.
  //2. Constructor that takes Name and Surname.
//Both constructors should print "Ingaaaa" and set the Birth Date to the current date and time.
//Instantiate one Baby object with each constructor and print their properties.

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baby baby1 = new Baby(); // Creating a Baby object using the default constructor
            baby1._name = "Umut";
            baby1._surname = "Aydın";
            baby1.BabyInfo();

            Baby baby2 = new Baby("Ahmet", "Çalışkan"); // Creating a Baby object using the constructor with parameters
            baby2.BabyInfo();
        }
    }

    public class Baby
    {
        public string _name;
        public string _surname;
        public DateTime _birthday;

        public Baby() // Default constructor
        {
            _birthday = DateTime.Now;
            Console.WriteLine("Ingaaaaa!");
        }
        
        public Baby(string name, string surname) // Constructor with parameters
        {
            _name = name;
            _surname = surname;
            _birthday = DateTime.Now;
            Console.WriteLine("Ingaaaaa!");
        }
              
        public void BabyInfo()  // Method to print out information about the Baby object
        {
            Console.WriteLine($"name: {_name}, surname: {_surname}, birthday: {_birthday}");
        }
    }
  
}

