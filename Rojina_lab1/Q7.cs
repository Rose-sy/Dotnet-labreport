using System;

class lab1 {
    static void Main(string[] args) {
        // Prompt the user to enter a number
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        // Loop through 1 to 10 and print the multiplication table
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }
}
