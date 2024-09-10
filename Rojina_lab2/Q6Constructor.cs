using System;

namespace ConstructorDemo
{
    public class Person
    {
        // Fields
        public string Name;
        public int Age;
        public static int Population;

        // 1. Default Constructor
        public Person()
        {
            Name = "Unknown";
            Age = 0;
            Console.WriteLine("Default Constructor Called");
        }

        // 2. Parameterized Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Parameterized Constructor Called");
        }

        // 3. Copy Constructor
        public Person(Person person)
        {
            Name = person.Name;
            Age = person.Age;
            Console.WriteLine("Copy Constructor Called");
        }

        // 4. Static Constructor
        static Person()
        {
            Population = 0;
            Console.WriteLine("Static Constructor Called");
        }

        // Method to display person details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    class Program
    {
        /*static void Main(string[] args)
        {
            // Static constructor is called automatically when the class is first used
            Console.WriteLine($"Initial Population: {Person.Population}");

            // 1. Default Constructor
            Person person1 = new Person();
            person1.DisplayDetails();
            Console.WriteLine();

            // 2. Parameterized Constructor
            Person person2 = new Person("Rojina", 20);
            person2.DisplayDetails();
            Console.WriteLine();

            // 3. Copy Constructor
            Person person3 = new Person(person2);
            person3.DisplayDetails();
            Console.WriteLine();

            // Access static field
            Person.Population = 3;
            Console.WriteLine($"Updated Population: {Person.Population}");

            // Keep the console window open
            Console.ReadLine();
        }*/
    }
}
