using System;

class Program
{
    static void Main()
    {
        // Input work data for each employee
        string managerName = "Manager";
        double managerRate = 30.0;
        int managerHours = 45;

        string technicianName = "Technician";
        double technicianRate = 25.0;
        int technicianHours = 50;

        // Calculate pay for each employee
        double managerPay = CalculatePay(managerRate, managerHours);
        double technicianPay = CalculatePay(technicianRate, technicianHours);

        // Display gross pay for each employee
        DisplayGrossPay(managerName, managerPay);
        DisplayGrossPay(technicianName, technicianPay);
    }

    static double CalculatePay(double rate, int hours)
    {
        double regularPay;
        double overtimePay;

        // Regular hours (up to 40 hours)
        if (hours <= 40)
        {
            regularPay = rate * hours;
            overtimePay = 0.0;
        }
        else // Overtime hours (more than 40 hours)
        {
            regularPay = rate * 40;
            overtimePay = rate * 1.5 * (hours - 40);
        }

        // Total pay including regular and overtime pay
        double totalPay = regularPay + overtimePay;

        return totalPay;
    }

    static void DisplayGrossPay(string employee, double pay)
    {
        Console.WriteLine($"{employee}'s gross pay: ${pay:F2}");
    }
}
