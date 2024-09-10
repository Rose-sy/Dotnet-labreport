using System;

namespace ShapeDemo
{
    // Base class Shape
    public class Shape
    {
        // Properties
        public double Length { get; set; }
        public double Breadth { get; set; }

        // Default constructor
        public Shape()
        {
            Length = 0;
            Breadth = 0;
        }

        // Parameterized constructor
        public Shape(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        // Constructor for Rectangle class
        public Rectangle(double length, double breadth) : base(length, breadth)
        {
        }

        // Method to calculate the area of the rectangle
        public double CalculateArea()
        {
            return Length * Breadth;
        }
    }

    class Program
    {
        /*static void Main(string[] args)
        {
            // Creating an instance of Rectangle with parameterized constructor
            Rectangle rectangle = new Rectangle(5.0, 3.0);

            // Calculating the area of the rectangle
            double area = rectangle.CalculateArea();

            // Displaying the results
            Console.WriteLine("Rectangle Details:");
            Console.WriteLine($"Length: {rectangle.Length}");
            Console.WriteLine($"Breadth: {rectangle.Breadth}");
            Console.WriteLine($"Area: {area}");

            // Keep the console window open
            Console.ReadLine();
        }*/
    }
}
