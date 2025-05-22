using System;
class ProjectedRaises
{
    public static void Run()
    {
        const double RAISE_PERCENT = 0.04; // 4% raise

        double employee1Salary = 50000; // Employee 1's salary= $50,000
        double employee2Salary = 60000; // Employee 2's salary= $60,000
        double employee3Salary = 70000; // Employee 3's salary= $70,000

        Console.WriteLine($"Next year employee 1 will earn: {employee1Salary * (1 + RAISE_PERCENT):C}");
        Console.WriteLine($"Next year employee 2 will earn: {employee2Salary * (1 + RAISE_PERCENT):C}");
        Console.WriteLine($"Next year employee 3 will earn: {employee3Salary * (1 + RAISE_PERCENT):C}");
    }
}
