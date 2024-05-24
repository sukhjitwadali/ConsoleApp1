using System;

class Program
{
    static void Main()
    {
        // Input attendance data for each event
        string eventName = "Seminar A";
        int registrants = 100;
        int attendees = 80;

        // Calculate attendance rate for the event
        double attendanceRate = CalculateAttendanceRate(registrants, attendees);

        // Categorize the event based on attendance
        string category = CategorizeAttendance(attendanceRate);

        // Display the results
        DisplayEventAttendance(eventName, registrants, attendees, attendanceRate, category);
    }

    static double CalculateAttendanceRate(int registrants, int attendees)
    {
        // Calculate attendance rate as a percentage
        return (double)attendees / registrants * 100;
    }

    static string CategorizeAttendance(double attendanceRate)
    {
        // Categorize events based on attendance rate
        if (attendanceRate >= 80)
        {
            return "High Attendance";
        }
        else if (attendanceRate >= 60)
        {
            return "Medium Attendance";
        }
        else
        {
            return "Low Attendance";
        }
    }

    static void DisplayEventAttendance(string eventName, int registrants, int attendees, double attendanceRate, string category)
    {
        // Display event attendance details
        Console.WriteLine($"Event: {eventName}");
        Console.WriteLine($"Registrants: {registrants}");
        Console.WriteLine($"Attendees: {attendees}");
        Console.WriteLine($"Attendance Rate: {attendanceRate:F2}%");
        Console.WriteLine($"Category: {category}");
    }
}
