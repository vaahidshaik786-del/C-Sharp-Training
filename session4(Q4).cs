using System;
using System.Collections.Generic;

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }

    public Employee(string name, string department, int salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee("Amit", "IT", 60000),
            new Employee("Rahul", "IT", 65000),
            new Employee("Priya", "IT", 70000),

            new Employee("Kiran", "HR", 40000),
            new Employee("Neha", "HR", 45000),

            new Employee("Arjun", "Sales", 55000),
            new Employee("Ravi", "Sales", 65000)
        };

        Dictionary<string, int> departmentSalary =
            new Dictionary<string, int>();

        foreach (Employee emp in employees)
        {
            if (departmentSalary.ContainsKey(emp.Department))
            {
                departmentSalary[emp.Department] += emp.Salary;
            }
            else
            {
                departmentSalary[emp.Department] = emp.Salary;
            }
        }

        string highestDepartment = "";
        int highestSalary = 0;

        foreach (var item in departmentSalary)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");

            if (item.Value > highestSalary)
            {
                highestSalary = item.Value;
                highestDepartment = item.Key;
            }
        }

        Console.WriteLine($"Highest paying: {highestDepartment}");
    }
}