// Namespace1.cs
using System;

namespace Namespace1
{
    public class Employee
    {
        // Fields
        public string Name;
        public string Email;
        public double Salary;

        // Constructor
        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }
}
