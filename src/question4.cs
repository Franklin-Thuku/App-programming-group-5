using System;

class Program
{
    static void Main()
    {
        int attempts = 0;
        const int MAX_ATTEMPTS = 3;

        Console.WriteLine("--- AREA CALCULATOR ---");
        Console.WriteLine("1. Triangle  2. Rectangle  3. Circle\n");

        while (attempts < MAX_ATTEMPTS)
        {
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            // We use a switch to handle the logic cleanly
            switch (choice)
            {
                case "1":
                    CalculateTriangle();
                    return; // Exit the program entirely after success
                case "2":
                    CalculateRectangle();
                    return;
                case "3":
                    CalculateCircle();
                    return;
                default:
                    attempts++;
                    int remaining = MAX_ATTEMPTS - attempts;
                    if (remaining > 0)
                        Console.WriteLine($"Invalid choice. {remaining} attempt(s) left.\n");
                    else
                        Console.WriteLine("Max attempts reached. Goodbye.");
                    break;
            }
        }
    }

    // Moving logic into methods makes Main() much easier to read!
    static void CalculateTriangle()
    {
        double b = GetSafeDouble("Enter base: ");
        double h = GetSafeDouble("Enter height: ");
        Console.WriteLine($"Area of Triangle = {0.5 * b * h:F2}");
    }

    static void CalculateRectangle()
    {
        double l = GetSafeDouble("Enter length: ");
        double w = GetSafeDouble("Enter breadth: ");
        Console.WriteLine($"Area of Rectangle = {l * w:F2}");
    }

    static void CalculateCircle()
    {
        double r = GetSafeDouble("Enter radius: ");
        Console.WriteLine($"Area of Circle = {Math.PI * Math.Pow(r, 2):F2}");
    }

    // This helper method prevents the program from crashing on bad input
    static double GetSafeDouble(string prompt)
    {
        double result;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out result) && result >= 0)
                return result;
            
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }
}