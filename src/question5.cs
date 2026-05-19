using System;

class SalesProgram
{
    public static void Run()
    {
        const int NUM_SALESMEN = 10;
        const int NUM_ITEMS = 5;

        string[] salesmanNames = new string[NUM_SALESMEN];
        int[,] sales = new int[NUM_SALESMEN, NUM_ITEMS];
        int[] totalSales = new int[NUM_SALESMEN];
        int grandTotal = 0;

        // Input Section
        for (int i = 0; i < NUM_SALESMEN; i++)
        {
            string salesman_name;
            while (true)
            {
                Console.Write("Enter salesman name: ");
                salesman_name = Console.ReadLine();
                
                // Validate that name is not empty and not purely numeric
                if (!string.IsNullOrWhiteSpace(salesman_name) && !int.TryParse(salesman_name, out _))
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid name (not a number).");
            }
            salesmanNames[i] = salesman_name;

            for (int j = 0; j < NUM_ITEMS; j++)
            {
                Console.Write($"Enter sales for Item {j + 1}: ");
                sales[i, j] = int.Parse(Console.ReadLine());
                
                // Accumulate totals
                totalSales[i] += sales[i, j];
                grandTotal += sales[i, j];
            }
            Console.WriteLine();
        }

        // Output Section
        Console.WriteLine("Name\t\tItem1\tItem2\tItem3\tItem4\tItem5\tTotalSales");
        Console.WriteLine("___________________________________________________");

        for (int i = 0; i < NUM_SALESMEN; i++)
        {
            // Print Name and all sales on one line
            Console.Write(salesmanNames[i] + "\t");
            
            // Print Sales for each item
            for (int j = 0; j < NUM_ITEMS; j++)
            {
                Console.Write(sales[i, j] + "\t");
            }
            
            // Print individual total
            Console.WriteLine(totalSales[i]);
        }

        Console.WriteLine("___________________________________________________");
        Console.WriteLine($"GrandTotal\t\t\t\t\t\t\t{grandTotal}");
        
        Console.ReadKey();
    }
}