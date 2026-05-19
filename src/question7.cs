/*
Using arrays of objects, write a C# program that can be
 used by the University Library to do the following:
 i) Allow the book’s code and name to be entered and 
 stored for all the books in the library. 
 ii) Allow the Librarian to display on the screen all 
 the books codes and names in the Library
*/

using System;
using System.Collections.Generic;

public class Books
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}

public static class Question7
{
    public static void Run()
    {
        Console.WriteLine("QUESTION 7: LIBRARY BOOKS");

        List<Books> library = new();

        Console.Write("How many books? ");
        int count = int.TryParse(Console.ReadLine(), out int result) && result > 0 ? result : 0;

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nBook #{i + 1}");
            Console.Write("  Code: ");
            string code = Console.ReadLine() ?? string.Empty;
            Console.Write("  Name: ");
            string name = Console.ReadLine() ?? string.Empty;
            library.Add(new Books { Code = code, Name = name });
        }

        Console.WriteLine("\nLibrary books:");
        foreach (var book in library)
        {
            Console.WriteLine($"Code: {book.Code}, Name: {book.Name}");
        }
    }
}
