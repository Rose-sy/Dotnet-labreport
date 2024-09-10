using System;

namespace GenericDemo
{
    // Generic class
    public class Box<T>
    {
        // Field to store the value of type T
        private T _value;

        // Constructor to initialize the value
        public Box(T value)
        {
            _value = value;
        }

        // Method to get the value
        public T GetValue()
        {
            return _value;
        }

        // Method to set the value
        public void SetValue(T value)
        {
            _value = value;
        }

        // Generic method to compare two values
        public bool Compare<T> (T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    class Program
    {
       /* static void Main(string[] args)
        {
            // Creating a Box object for integers
            Box<int> intBox = new Box<int>(10);
            Console.WriteLine($"Integer Box contains: {intBox.GetValue()}");

            // Changing the value in the integer Box
            intBox.SetValue(20);
            Console.WriteLine($"Updated Integer Box contains: {intBox.GetValue()}");

            // Creating a Box object for strings
            Box<string> stringBox = new Box<string>("Hello");
            Console.WriteLine($"String Box contains: {stringBox.GetValue()}");

            // Changing the value in the string Box
            stringBox.SetValue("World");
            Console.WriteLine($"Updated String Box contains: {stringBox.GetValue()}");

            // Using the Compare method
            Console.WriteLine($"Are 'Hello' and 'Hello' equal? {stringBox.Compare("Hello", "Hello")}");
            Console.WriteLine($"Are 10 and 20 equal? {intBox.Compare(10, 20)}");

            // Keep the console window open
            Console.ReadLine();
        }*/
    }
}
