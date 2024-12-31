// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace ArrayProblem
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }

        public Employee(int employeeID, string name, string designation, double salary)
        {
            EmployeeID = employeeID;
            Name = name;
            Designation = designation;
            Salary = salary;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"ID: {EmployeeID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Designation: {Designation}");
            Console.WriteLine($"Salary: {Salary:C}");
        }

        public void SalaryHike(double percentage)
        {
            if (percentage > 0)
            {
                double hike = Salary * (percentage / 100);
                Salary += hike;
                Console.WriteLine($"Salary hiked by {percentage}% ({hike}). New Salary: {Salary}");
            }
            else
            {
                Console.WriteLine("Percentage must be in positive");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101, "Alice", "Software Engineer", 60000);

            emp.DisplayDetails();
            emp.SalaryHike(30);
            emp.DisplayDetails();//for updated
        }
    }
}
