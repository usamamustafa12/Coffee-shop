using System;
using System.Collections.Generic;

class CoffeeShop
{
    static void Main(string[] args)
    {
        Dictionary<string, double> menu = new Dictionary<string, double>
        {
            { "Espresso", 2.50 },
            { "Americano", 3.00 },
            { "Latte", 3.50 },
            { "Cappuccino", 3.75 },
            { "Mocha", 4.00 },
            { "Tea", 1.50 }
        };

        double totalBill = 0;
        bool isOrdering = true;

        Console.WriteLine("Welcome to the Coffee Shop!");

        while (isOrdering)
        {
            Console.WriteLine("\nMenu:");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Key}: ${item.Value:F2}");
            }

            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Order Item");
            Console.WriteLine("2. Show Bill");
            Console.WriteLine("3. Exit");

            Console.Write("\nPlease choose an option (1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the name of the item you want to order: ");
                    string order = Console.ReadLine();

                    if (menu.ContainsKey(order))
                    {
                        totalBill += menu[order];
                        Console.WriteLine($"You have ordered a {order}. Current total: ${totalBill:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, we don't have that item on the menu.");
                    }
                    break;

                case "2":
                    Console.WriteLine($"\nYour total bill is: ${totalBill:F2}");
                    break;

                case "3":
                    Console.WriteLine("Thank you for visiting our Coffee Shop! Have a great day!");
                    isOrdering = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option (1-3).");
                    break;
            }
        }
    }
}
