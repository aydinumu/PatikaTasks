// Note: A separate README was not created as everything is done within a single file.

// Task: Create an application that calculates the area of different geometric shapes (Square, Rectangle, RightTriangle) using inheritance and polymorphism.
// The base class, `BaseShapes`, will define properties for width and height, and a virtual method to calculate the area.
// Override the area calculation for the RightTriangle class.

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create Objects with width and height then write area on the console with method
            Square square = new Square(5, 5);
            Rectangle rectangle = new Rectangle(10, 5);
            RightTriangle triangle = new RightTriangle(4, 10);
            square.CalculateArea();        
            rectangle.CalculateArea();            
            triangle.CalculateArea();
        }
    }

    // Base class for all geometric shapes
    public class BaseShapes
    {
        // Properties for width and height of the shape
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructor to initialize the width and height
        public BaseShapes(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Virtual method to calculate the area of the shape
        public virtual void CalculateArea()
        {
            double BaseArea = Width * Height;
            Console.WriteLine($"Area is : {BaseArea}\n----");
        }
    }

    //Derivered classes representing Square, Rectangle and RightTriangle
    public class Square : BaseShapes
    {
        public Square(double width, double height) : base(width, height)        {        }
    }

    public class Rectangle : BaseShapes
    {
        public Rectangle(double width, double height) : base(width, height)        {        }
    }

    public class RightTriangle : BaseShapes
    {
        public RightTriangle(double width, double height) : base(width, height)        {        }
        // Override method to calculate the area of the triangle
        public override void CalculateArea()
        {
            double area = (Width * Height) / 2;
            Console.WriteLine($"Area is : {area}\n----");
        }
    }
}
