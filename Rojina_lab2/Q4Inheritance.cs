using System;

namespace InheritanceDemo
{
    // Base class for all examples
    public class Person
    {
        public string Name;
        public int Age;

        public void DisplayPersonDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    // 1. Single Inheritance: Employee inherits from Person
    public class Employee : Person
    {
        public double Salary;

        public void DisplayEmployeeDetails()
        {
            DisplayPersonDetails();
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }

    // 2. Multilevel Inheritance: Manager inherits from Employee
    public class Manager : Employee
    {
        public string Department;

        public void DisplayManagerDetails()
        {
            DisplayEmployeeDetails();
            Console.WriteLine($"Department: {Department}");
        }
    }

    // 3. Hierarchical Inheritance: Customer also inherits from Person
    public class Customer : Person
    {
        public string CustomerID;

        public void DisplayCustomerDetails()
        {
            DisplayPersonDetails();
            Console.WriteLine($"Customer ID: {CustomerID}");
        }
    }

    class Program
    {
       /* static void Main(string[] args)
        {
            // Single Inheritance Example
            Console.WriteLine("Single Inheritance Example:");
            Employee emp = new Employee { Name = "Kalpana Karki", Age = 30, Salary = 50000 };
            emp.DisplayEmployeeDetails();
            Console.WriteLine();

            // Multilevel Inheritance Example
            Console.WriteLine("Multilevel Inheritance Example:");
            Manager mgr = new Manager { Name = "Kedar Adhikari", Age = 40, Salary = 90000, Department = "HR" };
            mgr.DisplayManagerDetails();
            Console.WriteLine();

            // Hierarchical Inheritance Example
            Console.WriteLine("Hierarchical Inheritance Example:");
            Customer cust = new Customer { Name = "Rojina Adhikari", Age = 25, CustomerID = "C12345" };
            cust.DisplayCustomerDetails();

            // Keep the console window open
            Console.ReadLine();
        }*/
    }
}
