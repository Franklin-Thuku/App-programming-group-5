using System;

class Program
{
    static void Main()
    {
        int attempts = 0;
        const int MAX_ATTEMPTS = 3;

        Console.WriteLine("AREA CALCULATOR");
        Console.WriteLine("1. Triangle  2. Rectangle  3. Circle\n");

        while (attempts < MAX_ATTEMPTS)
        {
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter base: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area = {0.5 * b * h:F2}\n");
                break;
            }
            else if (choice == "2")
            {
                Console.Write("Enter length: ");
                double l = double.Parse(Console.ReadLine());
                Console.Write("Enter breadth: ");
                double w = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area = {l * w:F2}\n");
                break;
            }
            else if (choice == "3")
            {
                Console.Write("Enter radius: ");
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area = {Math.PI * r * r:F2}\n");
                break;
            }
            else
            {
                attempts++;
                if (attempts < MAX_ATTEMPTS)
                    Console.WriteLine($"Wrong choice. {MAX_ATTEMPTS - attempts} attempt(s) left.\n");
                else
                    Console.WriteLine("Max attempts reached. Goodbye.");
                    
            }
        }
        
    }
}