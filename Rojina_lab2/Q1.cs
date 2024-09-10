using System;

namespace EmployeeApp
{
    class Employee
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

    class Program
    {
        /*static void Main(string[] args)
        {
            // Creating an object of Employee
            Employee emp = new Employee("Rojina Adhikari", "rojinaaa300@gmail.com", 70000);

            // Displaying the employee details
            emp.DisplayEmployeeDetails();

            // Keep the console window open
            Console.ReadLine();
        }*/
    }
}
