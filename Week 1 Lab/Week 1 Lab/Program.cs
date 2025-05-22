using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nChoose a program to run:");
            Console.WriteLine("1. InchesToCentimeters");
            Console.WriteLine("2. InchesToCentimetersInteractive");
            Console.WriteLine("3. ProjectedRaises");
            Console.WriteLine("4. ProjectedRaisesInteractive");
            Console.WriteLine("5. MoveEstimator");
            Console.WriteLine("6. HoursAndMinutes");
            Console.WriteLine("7. Eggs");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    InchesToCentimeters.Run();
                    break;
                case "2":
                    InchesToCentimetersInteractive.Run();
                    break;
                case "3":
                    ProjectedRaises.Run();
                    break;
                case "4":
                    ProjectedRaisesInteractive.Run();
                    break;
                case "5":
                    MoveEstimator.Run();
                    break;
                case "6":
                    HoursAndMinutes.Run();
                    break;
                case "7":
                    Eggs.Run();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}