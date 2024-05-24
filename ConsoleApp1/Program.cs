using System;

class Program
{
    static void Main()
    {
        // Define prices for each item
        double tvPrice = 350.89;
        double smartphonePrice = 239.99;
        double laptopPrice = 129.75;

        // Accept sales data
        int tvSold, smartphonesSold, laptopsSold;
        InputSalesData(out tvSold, out smartphonesSold, out laptopsSold);

        // Calculate total earnings
        double totalEarnings = CalculateTotalEarnings(tvSold, smartphonesSold, laptopsSold, tvPrice, smartphonePrice, laptopPrice);

        // Display total earnings
        Console.WriteLine($"Total earnings: ${totalEarnings:F2}");
    }

    static void InputSalesData(out int tvSold, out int smartphonesSold, out int laptopsSold)
    {
        Console.Write("Enter the number of TVs sold: ");
        tvSold = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of smartphones sold: ");
        smartphonesSold = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of laptops sold: ");
        laptopsSold = int.Parse(Console.ReadLine());
    }

    static double CalculateTotalEarnings(int tvSold, int smartphonesSold, int laptopsSold, double tvPrice, double smartphonePrice, double laptopPrice)
    {
        // Calculate total sales
        double totalSales = tvSold * tvPrice + smartphonesSold * smartphonePrice + laptopsSold * laptopPrice;

        // Fixed salary for the salesperson
        double fixedSalary = 2000.0; // Assuming a fixed salary of $2000

        // Total earnings = Fixed salary + Commission (5% of total sales)
        double totalEarnings = fixedSalary + 0.05 * totalSales;

        return totalEarnings;
    }
}
