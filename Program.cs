using System;

class Program
{
    static void Main()
    {
        int number = 123;
        bool flag = true;
        string? nullableString = null;
        object? nullObject = null;

        Console.WriteLine("Using Convert.ToString():");
        Console.WriteLine(Convert.ToString(number));
        Console.WriteLine(Convert.ToString(flag));
        Console.WriteLine(Convert.ToString(nullableString));
        Console.WriteLine(Convert.ToString(nullObject));

        Console.WriteLine("\nUsing ToString() with null check:");
        if (nullableString != null)
        {
            Console.WriteLine(nullableString.ToString());
        }
        else
        {
            Console.WriteLine("nullableString is null");
        }

        Console.WriteLine("\nUsing ?. operator:");
        Console.WriteLine(nullableString?.ToString() ?? "nullableString is null");

        Console.WriteLine(nullObject?.ToString() ?? "nullObject is null");
    }
}
