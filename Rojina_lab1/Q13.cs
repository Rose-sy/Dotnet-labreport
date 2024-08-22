using System;

class Program
{
    static void Main(string[] args)
    {
        // Define a string array
        string[] stringArray = { "Hello", "World", "from", "C#", "programming" };
        
        // Convert the string array to a single string with spaces between words
        string result = string.Join(" ", stringArray);
        
        // Display the result
        Console.WriteLine("Converted string: " + result);
    }
}
