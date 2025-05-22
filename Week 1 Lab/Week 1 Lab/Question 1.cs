using System;
class InchesToCentimeters
{
    public static void Run()
    {
        const double CMperINCH = 2.54; // Conversion factor
        double inches = 3.0;
        double centimeters = inches * CMperINCH; // Convert inches to centimeters

        Console.WriteLine($"{inches} inches is equal to {centimeters} centimeters.");

    }
}
