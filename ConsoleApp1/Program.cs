using System;

class Program
{
    static void Main()
    {
        double weight, height;
        // Accept user input for weight and height
        InputWeightAndHeight(out weight, out height);

        // Calculate BMI
        double bmi = CalculateBMI(weight, height);

        // Categorize BMI
        string category = CategorizeBMI(bmi);

        // Display results
        DisplayResults(weight, height, bmi, category);
    }

    static void InputWeightAndHeight(out double weight, out double height)
    {
        Console.Write("Enter your weight in kilograms: ");
        weight = double.Parse(Console.ReadLine());

        Console.Write("Enter your height in meters: ");
        height = double.Parse(Console.ReadLine());
    }

    static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }

    static string CategorizeBMI(double bmi)
    {
        if (bmi < 18.5)
            return "Underweight";
        else if (bmi < 24.9)
            return "Normal weight";
        else if (bmi < 29.9)
            return "Overweight";
        else
            return "Obese";
    }

    static void DisplayResults(double weight, double height, double bmi, string category)
    {
        Console.WriteLine($"Weight: {weight} kg, Height: {height} m");
        Console.WriteLine($"BMI: {bmi:F2}");
        Console.WriteLine($"Category: {category}");
    }
}
