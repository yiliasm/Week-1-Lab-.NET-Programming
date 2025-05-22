using System;
class Eggs
{
    public static void Run()
    {
        int chicken1 = 37;
        int chicken2 = 20;
        int chicken3 = 30;
        int chicken4 = 40;

        int totalEggs = chicken1 + chicken2 + chicken3 + chicken4;
        int dozens = totalEggs / 12; // Calculate dozens of eggs
        int remainingEggs = totalEggs % 12; // Calculate remaining eggs

        Console.WriteLine($"{totalEggs} eggs is {dozens} dozen and {remainingEggs} eggs.");
    }
}