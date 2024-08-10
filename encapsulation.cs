// In this example, create a `Car` class with properties: Brand, Model, Color, and Door Count.
// Implement encapsulation for the Door Count property.
// If a value other than 2 or 4 is assigned to Door Count, display a warning and set the value to -1.

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Corolla", "Red", 4);
            Console.WriteLine($"Door: {car1.Door}"); // Should print 4

            Car car2 = new Car("Honda", "Civic", "Blue", 3);
            Console.WriteLine($"Door: {car2.Door}"); // Should print -1 with a warning message
        }

        public class Car
        {
            private string _brand;
            private string _model;
            private string _color;
            private int _door;

            public Car(string brand, string model, string color, int door)
            {
                _brand = brand;
                _model = model;
                _color = color;
                Door = door;    // Property to trigger validation
            }
            public int Door
            {
                get { return _door; }
                set
                {
                    if (value == 2 || value == 4) // Checking if user entered 2 or 4
                    {
                        _door = value;
                    } else
                      {
                        _door = -1;
                        Console.WriteLine("_door could not be assigned !");
                      }
                }
            }
        }
    }
}

