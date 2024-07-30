// Öğrencilerin ve öğretmenlerin bilgilerini yönetmek için Person adında genel bir sınıf oluşturmanız isteniyor. Bu sınıfın özellikleri şunlar olmalı: Ad, Soyad, Doğum Tarihi.
// Person adında bir sınıf oluşturun ve bu özellikleri içeren public property'ler (get/set) tanımlayın.
// Main metodu içinde, bu sınıftan birkaç öğrenci ve öğretmen nesnesi oluşturun ve bilgilerini konsola yazdırın.

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating students
            Person student1 = new Person("Umut", "Aydın", 1994);
            Person student2 = new Person("Ahmet", "Çelik", 2000);

            // Creating teacher
            Person teacher1 = new Person("Merve", "Yılmaz", 1985);

            // Printing informations of students and teacher
            student1.PrintInfo();
            student2.PrintInfo();
            teacher1.PrintInfo();
        }
    }

    //Creating the class
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

        // Constructor
        public Person(string firstName, string lastName, int birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
        }

        // Method to print informations
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Birth Year: {BirthYear}");
        }
    }
}
