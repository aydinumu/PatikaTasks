// Note: A separate README file is not used as all tasks are completed within a single file.

//You're tasked with creating a program to represent company employees. Each employee has a name, surname, and department.
//Employees have different roles, and when the Task() method is called, each should print their specific job function to the console.
//For example, if Task() is called on a project manager named Hasan, the output should be: "I work as a Project Manager."

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creating instances for different employees
            Employee developer = new SoftwareDeveloper()
            {
                FirstName = "Ali",
                LastName = "Ermiş",
                Department = "Software"
            };

            Employee manager = new ProjectManager()
            {
                FirstName = "Hasan",
                LastName = "Çıldırmış",
                Department = "Management"
            };

            Employee buyer = new Buyer()
            {
                FirstName = "Umut",
                LastName = "Aydın",
                Department = "Procurement"
            };

            // Calling the Task method for each employee
            developer.Task();
            manager.Task();
            buyer.Task();
        }
    }

    // Base class representing a generic employee
    public abstract class Employee
    {
        // Creating Properties
        public string FirstName { get; set; }  
        public string LastName { get; set; }  
        public string Department { get; set; }

        // Abstract method to be implemented by derived classes, representing the employee's specific task
        public abstract void Task();
    }

    // Derived class representing a Software Developer
    public class SoftwareDeveloper : Employee
    {
        public override void Task()
        {
            // Prints the specific task for a software developer
            Console.WriteLine($"{FirstName} {LastName} is working as a Software Developer.");
        }
    }

    // Derived class representing a Project Manager
    public class ProjectManager : Employee
    {
        public override void Task()
        {
            // Prints the specific task for a project manager
            Console.WriteLine($"{FirstName} {LastName} is working as a Project Manager.");
        }
    }

    // Derived class representing a Sales Representative
    public class Buyer : Employee
    {
        public override void Task()
        {
            // Prints the specific task for a sales representative
            Console.WriteLine($"{FirstName} {LastName} is working as a Procurement Engineer.");
        }
    }
}
