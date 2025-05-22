using System;
class ProjectedRaisesInteractive
{
    public static void Run()
    { 
        const double RAISE_PERCENT = 0.04; // 4% raise

        Console.Write("Enter the salary of employee 1: ");
        double employee1Salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the salary of employee 2: ");
        double employee2Salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the salary of employee 3: ");
        double employee3Salary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Next year employee 1 will earn: {employee1Salary * (1 + RAISE_PERCENT):C}");
        Console.WriteLine($"Next year employee 2 will earn: {employee2Salary * (1 + RAISE_PERCENT):C}");
        Console.WriteLine($"Next year employee 3 will earn: {employee3Salary * (1 + RAISE_PERCENT):C}");
    }
}