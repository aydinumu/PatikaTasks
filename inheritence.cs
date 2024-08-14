
// I did not create a ReadME file because I worked in one file.
// Create a base class named `BasePerson` with properties: FirstName, LastName.
// Add a method to print the full name to the console.
// Create two derived classes from `BasePerson`: `Student` and `Teacher`.
// `Student` class adds a property: StudentNumber and a method to print StudentNumber along with the full name.
// `Teacher` class adds a property: Salary and a method to print Salary along with the full name.
// Implement examples for both student and teacher, assign values, and print them to the console.

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new Student object and set its properties
            Student s1 = new Student(); 
            s1.Name = "Umut";
            s1.SurName = "Aydın";
            s1.StudentNumber = 123;

            // Create a new Teacher object and set its properties
            Teacher t1 = new Teacher();
            t1.Name = "İrem";
            t1.SurName = "Solmaz";
            t1.Salary = 50000;

            // Print the informations
            s1.PrintStudentInfo();
            t1.PrintTeacherInfo();
        }
    }

    // Base class that provides common properties and methods for Student and Teacher classes
    public class BasePerson
    {
        // Properties to store the name and surname of the person
        public string Name;
        public string SurName;

        // Method to print the name and surname of the person
        public void PrintInfo()
        {
            Console.WriteLine($"Name : {Name} \nSurname : {SurName}");
        }
    }

    // Student class that inherits from BasePerson and adds a StudentNumber property
    public class Student : BasePerson
    {
        // Property to store the student's number
        public int StudentNumber;
        // Method to print student-specific information
        public void PrintStudentInfo()
        {
            // Print the base class info (name and surname) and its own info
            PrintInfo();
            Console.WriteLine($"Student Number : {StudentNumber}\n");
            Console.WriteLine("-------\n");
        }
    }

    // Teacher class that inherits from BasePerson and adds a Salary property
    public class Teacher : BasePerson
    {
        // Property to store the teacher's salary
        public decimal Salary;
        // Method to print teacher-specific information
        public void PrintTeacherInfo()
        {
            // Print the base class info (name and surname) and its own info
            PrintInfo();
            Console.WriteLine($"Salary : {Salary}\n");
            Console.WriteLine("-------\n");
        }
    }
}
