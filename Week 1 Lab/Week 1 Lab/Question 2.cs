using System;
class InchesToCentimetersInteractive
{ public static void Run()
    {
        const double CMperINCH = 2.54; // Conversion factor
        Console.Write("Enter the number of inches: ");
        double inches = Convert.ToDouble(Console.ReadLine()); // Read user input    
        double centimeters = inches * CMperINCH; // Convert inches to centimeters   
        Console.WriteLine($"{inches} inches is equal to {centimeters} centimeters.");   
    }
}
