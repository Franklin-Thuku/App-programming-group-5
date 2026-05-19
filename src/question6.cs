/*
Write a C# program that uses a class called Business 
that accepts the buying price, transport cost
 and selling price of an item and then computes 
 the profit or loss made on the item. When giving 
 theoutput, theprogram should be specific if it was
  a profit or loss that was made. The class should 
  have a constructorthatinitializes buying price, 
  selling price and transport cost to specified 
  values and a default constructor thatinitializes
   these values to 0
*/

using System;

class Question6
{
    public static void Run()
    {
        Console.WriteLine("QUESTION 6: BUSINESS PROFIT/LOSS");

        double buyingPrice = ReadPositiveDouble("Enter buying price: ");
        double transportCost = ReadPositiveDouble("Enter transport cost: ");
        double sellingPrice = ReadPositiveDouble("Enter selling price: ");

        Business business = new(buyingPrice, transportCost, sellingPrice);
        business.CalculateProfitOrLoss();
    }

    private static double ReadPositiveDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (double.TryParse(input, out double value) && value >= 0)
                return value;

            Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
        }
    }
}

class Business
{
    private double buyingPrice;
    private double transportCost;
    private double sellingPrice;

    // Parameterized constructor
    public Business(double buyingPrice, double transportCost, double sellingPrice)
    {
        this.buyingPrice = buyingPrice;
        this.transportCost = transportCost;
        this.sellingPrice = sellingPrice;
    }

    // Default constructor
    public Business()
    {
        this.buyingPrice = 0;
        this.transportCost = 0;
        this.sellingPrice = 0;
    }

    public void CalculateProfitOrLoss()
    {
        double totalCost = buyingPrice + transportCost;
        double profitOrLoss = sellingPrice - totalCost;

        if (profitOrLoss > 0)
        {
            Console.WriteLine($"Profit: {profitOrLoss:C}");
        }
        else if (profitOrLoss < 0)
        {
            Console.WriteLine($"Loss: {Math.Abs(profitOrLoss):C}");
        }
        else
        {
            Console.WriteLine("No profit, no loss.");
        }
    }
}