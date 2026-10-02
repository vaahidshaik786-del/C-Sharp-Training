using System;
using System.Collections.Generic;

class Program
{
    static bool IsBalanced(string text)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in text)
        {
            if (ch == '(' || ch == '[' || ch == '{')
            {
                stack.Push(ch);
            }
            else if (ch == ')' || ch == ']' || ch == '}')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char opening = stack.Pop();

                if ((ch == ')' && opening != '(') ||
                    (ch == ']' && opening != '[') ||
                    (ch == '}' && opening != '{'))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    static void Main()
    {
        string[] tests =
        {
            "{[()]}",
            "{[(])}",
            "(("
        };

        foreach (string test in tests)
        {
            if (IsBalanced(test))
                Console.WriteLine($"{test} -> balanced");
            else
                Console.WriteLine($"{test} -> not balanced");
        }
    }
}