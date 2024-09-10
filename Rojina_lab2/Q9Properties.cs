using System;

namespace PropertyDemo
{
    public class Person
    {
        // 1. Auto-Implemented Property
        public string Name { get; set; }

        // 2. Read-Only Property
        public int BirthYear { get; private set; }

        // 3. Write-Only Property
        private string _address;
        public string Address
        {
            set
            {
                _address = value;
                Console.WriteLine("Address set.");
            }
        }

        // 4. Computed Property
        public int Age
        {
            get
            {
                int currentYear = DateTime.Now.Year;
                return currentYear - BirthYear;
            }
        }

        // 5. Private Setter
        public string Email { get; private set; }

        // Constructor
        public Person(string name, int birthYear, string email)
        {
            Name = name;
            BirthYear = birthYear;
            Email = email;
        }

        // Method to display person details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Birth Year: {BirthYear}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    class Program
    {
        /*static void Main(string[] args)
        {
            // Creating an instance of the Person class
            Person person = new Person("Roshni Adhikari", 1999, "roshni@gmail.com");

            // Accessing and displaying properties
            Console.WriteLine("Initial Person Details:");
            person.DisplayDetails();

            // Modifying properties
            person.Name = "Rojina Adhikari";
            person.Address = "Kapan";

            // Displaying updated details
            Console.WriteLine("\nUpdated Person Details:");
            person.DisplayDetails();

            // Attempting to change Email (will not work due to private setter)
            // person.Email = "new.email@example.com"; // This line would cause a compilation error

            // Keep the console window open
            Console.ReadLine();
        }*/
    }
}
