using System;

class Question3
{
    public static void Run()
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

            Console.Write(
                "Enter credit limit: "
            );

            double creditLimit =
                Convert.ToDouble(
                    Console.ReadLine()
                );

            Console.Write(
                "Enter price: "
            );

            double price =
                Convert.ToDouble(
                    Console.ReadLine()
                );

            while (true)
            {
                Console.Write(
                    "Enter quantity: "
                );

                int quantity =
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
                    Console.WriteLine(
                        "Please re-enter the quantity."
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