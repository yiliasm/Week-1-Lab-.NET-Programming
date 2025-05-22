using System;
class InchesToCentimeters
{ static void Main()
    {
        const double CMperINCH = 2.54; // Conversion factor
        double inches = 3.0;
        double centimeters = inches * CMperINCH; // Convert inches to centimeters

        Console.WriteLine($"{inches} inches is equal to {centimeters} centimeters.");

    }
}
