using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> empty = new List<Student>();

        // First()
        try
        {
            var a = empty.First();
            Console.WriteLine($"First: {a}");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("First(): throws InvalidOperationException");
        }

        // FirstOrDefault()
        var b = empty.FirstOrDefault();

        if (b == null)
        {
            Console.WriteLine("FirstOrDefault(): returns null");
        }

        // Average()
        try
        {
            var c = empty.Average(s => s.Marks);
            Console.WriteLine($"Average: {c}");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Average(): throws InvalidOperationException");
        }

        // Sum()
        var d = empty.Sum(s => s.Marks);
        Console.WriteLine($"Sum(): {d}");

        // All()
        var e = empty.All(s => s.Marks > 1000);
        Console.WriteLine($"All(): {e}");
    }
}