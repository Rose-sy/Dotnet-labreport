using System;

namespace BinaryOperatorOverloading
{
    public class Point
    {
        // Fields representing the X and Y coordinates of the point
        public int X { get; set; }
        public int Y { get; set; }

        // Constructor to initialize the point
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Overloading the binary '+' operator
        public static Point operator +(Point p1, Point p2)
        {
            // Return a new Point that is the sum of the two points
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        // Method to display the point
        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }
    }

    class Program
    {
        /*static void Main(string[] args)
        {
            // Creating instances of the Point class
            Point p1 = new Point(5, 10);
            Point p2 = new Point(3, 4);

            // Displaying the original points
            Console.WriteLine("Original Points:");
            p1.Display();
            p2.Display();

            // Overloading the binary '+' operator to add two points
            Point p3 = p1 + p2;

            // Displaying the result of the addition
            Console.WriteLine("\nSum of Points:");
            p3.Display();

            // Keep the console window open
            Console.ReadLine();
        }*/
    }
}
