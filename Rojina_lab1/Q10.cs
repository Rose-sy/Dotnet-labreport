using System;

class lab1 {
    static void Main(string[] args) {
        Console.WriteLine("Enter an alphabet:");
        string input = Console.ReadLine();
        
        if (!string.IsNullOrEmpty(input)) {
            char ch = char.ToLower(input[0]);

            switch (ch) {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("\n{0} is a vowel", ch);
                    break;
                default:
                    // Ensure the input is a valid alphabet character
                    if (ch >= 'a' && ch <= 'z') {
                        Console.WriteLine("\n{0} is a consonant", ch);
                    } else {
                        Console.WriteLine("\nInput is not a valid alphabet character.");
                    }
                    break;
            }
        } else {
            Console.WriteLine("\nNo input provided.");
        }
    }
}
