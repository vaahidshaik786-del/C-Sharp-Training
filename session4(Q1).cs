using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;

        Console.Write("Before: ");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        k = k % arr.Length;

        for (int r = 0; r < k; r++)
        {
            int last = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = last;
        }

        Console.WriteLine();

        Console.Write("After: ");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}