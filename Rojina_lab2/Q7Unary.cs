using System;

namespace UnaryOperatorOverloading
{
    public class Complex
    {
        // Fields representing the real and imaginary parts of a complex number
        public double Real { get; set; }
        public double Imaginary { get; set; }

        // Constructor to initialize the complex number
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Overloading the unary '-' operator
        public static Complex operator -(Complex c)
        {
            return new Complex(-c.Real, -c.Imaginary);
        }

        // Method to display the complex number
        public void Display()
        {
            Console.WriteLine($"Complex Number: {Real} + {Imaginary}i");
        }
    }

    class Program
    {
      /* static void Main(string[] args)
        {
            // Creating an instance of the Complex class
            Complex c1 = new Complex(3, 4);

            // Displaying the original complex number
            Console.WriteLine("Original Complex Number:");
            c1.Display();

            // Overloading the unary '-' operator to negate the complex number
            Complex c2 = -c1;

            // Displaying the negated complex number
            Console.WriteLine("\nNegated Complex Number:");
            c2.Display();

            // Keep the console window open
            Console.ReadLine();
        }*/
    }
}
