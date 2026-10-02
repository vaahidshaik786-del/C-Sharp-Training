using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> sales = new List<int>
        {
            250, 300, 180, 420, 200
        };

        int total = 0;
        int passedDay = -1;

        for (int i = 0; i < sales.Count; i++)
        {
            total += sales[i];

            Console.WriteLine(
                $"Day {i + 1}: {sales[i]} (total {total})"
            );

            if (total > 1000 && passedDay == -1)
            {
                passedDay = i + 1;
            }
        }

        Console.WriteLine($"Passed 1000 on day {passedDay}");
    }
}