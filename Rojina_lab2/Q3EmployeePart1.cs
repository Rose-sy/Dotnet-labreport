// EmployeePart1.cs
using System;

namespace PartialClassExample
{
    public partial class Employee
    {
        // Fields
        public string Name;
        public string Email;

        // Constructor
        public Employee(string name, string email)
        {
            Name = name;
            Email = email;
        }

        // Method to display basic employee details
        public void DisplayBasicDetails()
        {
            Console.WriteLine("Basic Employee Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
