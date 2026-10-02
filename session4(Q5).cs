using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] userIds = { 101, 102, 103, 101, 104, 102, 105, 101 };

        HashSet<int> uniqueUsers = new HashSet<int>();

        int repeatEntries = 0;

        foreach (int id in userIds)
        {
            if (!uniqueUsers.Add(id))
            {
                repeatEntries++;
            }
        }

        Console.WriteLine($"Log entries: {userIds.Length}");
        Console.WriteLine($"Unique visitors: {uniqueUsers.Count}");
        Console.WriteLine($"Repeat entries: {repeatEntries}");
    }
}