using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine();

        List<Activity> activitiesList = new List<Activity>();

        Running running = new Running(30, 3);
        activitiesList.Add(running);
        Cycling cycling = new Cycling(45, 16);
        activitiesList.Add(cycling);
        Swimming swimming = new Swimming(60, 40);
        activitiesList.Add(swimming);


        foreach (Activity activity in activitiesList)
        {
            activity.DisplaySummary();

        }

        Console.WriteLine();
    }
}