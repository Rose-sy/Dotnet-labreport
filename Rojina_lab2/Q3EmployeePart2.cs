// EmployeePart2.cs
using System;

namespace PartialClassExample
{
    public partial class Employee
    {
        // Field for Salary
        public double Salary;

        // Method to set the salary
        public void SetSalary(double salary)
        {
            Salary = salary;
        }

        // Method to display complete employee details
        public void DisplayCompleteDetails()
        {
            DisplayBasicDetails();
            Console.WriteLine($"Salary: {Salary:C}");
        }
    }
}
