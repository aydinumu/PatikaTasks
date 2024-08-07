// This task involves creating a Book class for a library system with properties for book details and two constructors: one default and one parameterized.

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a book using the default constructor
            Book book1 = new Book();       // New is Used to create an object
            // Creating a book using the parameterized constructor
            Book book2 = new Book("Adı Aylin", "Ayşe", "Kulün", 398 , "Remzi Yayınevi");

            // Printing the information
            book1.PrintInfo();
            book2.PrintInfo();

        }
        // Class is a template for creating objects. Book is a class representing a book object.
        class Book
        {
            // Property: Attributes of an object.
            public string _bookName;
            public string _authorName;
            public string _authorSurname;
            public int _page;
            public string _publisher;
            public DateTime _registerDate;

            // Constructor: A method that runs when a new instance of a class is created.
            public Book() // Default constructor
            {
                Console.Write("Book Name : ");
                _bookName = Console.ReadLine();
                Console.Write("Author Name : ");
                _authorName = Console.ReadLine();
                Console.Write("Author Surname : ");
                _authorSurname = Console.ReadLine();
                Console.Write("Pages : ");
                _page = Convert.ToInt32(Console.ReadLine());
                Console.Write("Publisher : ");
                _publisher = Console.ReadLine();
                _registerDate = DateTime.Now; // Registration date is set to the current time
                Console.WriteLine("Book registered successfully!");
            }

            // Parameterized constructor
            public Book(string bookName, string authorName, string authorSurname, int page, string publisher)
            {
                _bookName = bookName;
                _authorName = authorName;
                _authorSurname= authorSurname;
                _page = page;
                _publisher = publisher;
                _registerDate = DateTime.Now; // Registration date is set to the current time
                Console.WriteLine("Book registered successfully!");
            }

            public void PrintInfo()   // Method to print book information
            {
                Console.WriteLine($"\nBook Name: {_bookName}");
                Console.WriteLine($"Author: {_authorName} {_authorSurname}");
                Console.WriteLine($"Pages: {_page}");
                Console.WriteLine($"Publisher: {_publisher}");
                Console.WriteLine($"Register Date: {_registerDate}\n");
            }
        }
    }
}

