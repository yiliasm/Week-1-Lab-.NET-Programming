using System;
class MoveEstimator
{
    public static void Run()
    { 
        const double BASE_RATE = 200.00; // Base rate for moving
        const double PER_HOUR = 150.00; // Rate per hour for moving
        const double PER_MILE = 2.00; // Rate per mile for moving

        Console.Write("Enter the number of hours for the move: ");
        double hours = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the number of miles for the move: ");
        double miles = Convert.ToDouble(Console.ReadLine());

        double totalCost = BASE_RATE + (PER_HOUR * hours) + (PER_MILE * miles);
        Console.WriteLine($"The estimated cost of the move is: {totalCost:C}");
    }
}
