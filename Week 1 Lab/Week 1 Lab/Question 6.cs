using System;
class HoursAndMinutes
{
    public static void Run()
    { 
        int minutes = 197;
        int hours = minutes / 60; // Calculate hours
        int minutesLeft = minutes % 60; // Calculate remaining minutes

        Console.WriteLine($"{minutes} minutes is {hours} hours and {minutesLeft} minutes.");
    }
}
   