using System;

class SalesProgram
{
    static void Main(string[] args)
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
            Console.Write("Enter salesman name: ");
            salesmanNames[i] = Console.ReadLine();

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
        Console.WriteLine("Name");
        Console.WriteLine("Item1 Item2 Item3 Item4 Item5 TotalSales");
        Console.WriteLine("___________________________________________________");

        for (int i = 0; i < NUM_SALESMEN; i++)
        {
            // Print Name
            Console.WriteLine(salesmanNames[i]);
            
            // Print Sales for each item
            for (int j = 0; j < NUM_ITEMS; j++)
            {
                Console.Write(sales[i, j] + "\t");
            }
            
            // Print individual total
            Console.WriteLine(totalSales[i]);
        }

        Console.WriteLine("___________________________________________________");
        Console.WriteLine($"GrandTotal {grandTotal}");
        
        Console.ReadKey();
    }
}