using System;

namespace VirtualMethodDemo
{
    // Base class
    public class Animal
    {
        // Virtual method
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        // Override the virtual method
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    // Derived class Cat
    public class Cat : Animal
    {
        // Override the virtual method
        public override void Speak()
        {
            Console.WriteLine("The cat meows.");
        }
    }

    // Derived class Cow
    public class Cow : Animal
    {
        // Override the virtual method
        public override void Speak()
        {
            Console.WriteLine("The cow moos.");
        }
    }

    class Program
    {
        /*static void Main(string[] args)
        {
            // Create instances of the derived classes
            Animal myDog = new Dog();
            Animal myCat = new Cat();
            Animal myCow = new Cow();

            // Call the Speak method on each object
            myDog.Speak();  // Output: The dog barks.
            myCat.Speak();  // Output: The cat meows.
            myCow.Speak();  // Output: The cow moos.

            // Keep the console window open
            Console.ReadLine();
        }*/
    }
}
