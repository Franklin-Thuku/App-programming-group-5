using System;

class Question3
{
    static void Main()
    {
        int numberOfCustomers;

        Console.Write("Enter number of customers: ");
        numberOfCustomers =
            Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= numberOfCustomers; i++)
        {
            Console.WriteLine(
                "\nCustomer " + i
            );

            double creditLimit;

            Console.Write(
                "Enter credit limit: "
            );

            creditLimit =
                Convert.ToDouble(
                    Console.ReadLine()
                );

            while (true)
            {
                double price;
                int quantity;

                Console.Write(
                    "Enter price: "
                );

                price =
                    Convert.ToDouble(
                        Console.ReadLine()
                    );

                Console.Write(
                    "Enter quantity: "
                );

                quantity =
                    Convert.ToInt32(
                        Console.ReadLine()
                    );

                double total =
                    price * quantity;

                if (total > creditLimit)
                {
                    Console.WriteLine(
                        "Sorry you cannot purchase goods worthy such a value on credit"
                    );
                }
                else
                {
                    Console.WriteLine(
                        "Thank You for purchasing from us"
                    );

                    Console.WriteLine(
                        "Value of purchase: "
                        + total
                    );

                    break;
                }
            }
        }

        Console.WriteLine(
            "\nAll customers processed."
        );
    }
}