using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Initialize inventory
        Dictionary<string, int> inventory = new Dictionary<string, int>()
        {
            { "Novels", 100 },
            { "Science Books", 80 }
        };

        // Input sales and restock data
        Dictionary<string, int> salesData, restockData;
        InputSalesAndRestockData(out salesData, out restockData);

        // Update inventory levels based on sales and restocking
        UpdateInventoryLevels(inventory, salesData, restockData);

        // Display current inventory status
        DisplayInventoryStatus(inventory);
    }

    static void InputSalesAndRestockData(out Dictionary<string, int> salesData, out Dictionary<string, int> restockData)
    {
        salesData = new Dictionary<string, int>();
        restockData = new Dictionary<string, int>();

        // Input sales data
        Console.WriteLine("Enter sales data:");
        salesData["Novels"] = GetQuantityFromUser("Novels sold: ");
        salesData["Science Books"] = GetQuantityFromUser("Science Books sold: ");

        // Input restock data
        Console.WriteLine("Enter restock data:");
        restockData["Novels"] = GetQuantityFromUser("Novels restocked: ");
        restockData["Science Books"] = GetQuantityFromUser("Science Books restocked: ");
    }

    static int GetQuantityFromUser(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    static void UpdateInventoryLevels(Dictionary<string, int> inventory, Dictionary<string, int> salesData, Dictionary<string, int> restockData)
    {
        foreach (var item in salesData)
        {
            if (inventory.ContainsKey(item.Key))
            {
                inventory[item.Key] -= item.Value;
            }
        }

        foreach (var item in restockData)
        {
            if (inventory.ContainsKey(item.Key))
            {
                inventory[item.Key] += item.Value;
            }
        }
    }

    static void DisplayInventoryStatus(Dictionary<string, int> inventory)
    {
        Console.WriteLine("Current Inventory Status:");
        foreach (var item in inventory)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
