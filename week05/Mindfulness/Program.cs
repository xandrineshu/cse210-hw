using System;
// Showing Creativity and Exceeding Requirements >o<

// To show creativity and exceed requirements, I tried to keep a log for how many times
// each activities were performed. I also tried to make sure that there were no prompts repeated. 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("");

        int breatheCount = 0;
        int reflectCount = 0;
        int listCount = 0;

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("     Welcome to the Mindfulness Program!     ");
        Console.WriteLine("---------------------------------------------");

        Console.WriteLine();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Please select one of the following activities: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                //Breathing
                case 1:
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathingActivity();
                    breatheCount++;
                    break;

                //Reflecting
                case 2:
                    Console.Clear();
                    ReflectingActivity reflection = new ReflectingActivity();
                    reflection.RunReflectingActivity();
                    reflectCount++;
                    break;

                //Listing
                case 3:
                    Console.Clear();
                    ListingActivity listing = new ListingActivity();
                    listing.RunListingActivity();
                    listCount++;
                    break;

                //quit
                case 4:
                    running = false;
                    Console.WriteLine("Awesome job! You completed the following activities: ");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine($"Breathing Activity: {breatheCount} times");
                    Console.WriteLine($"Reflecting Activity: {reflectCount} times");
                    Console.WriteLine($"Listing Activity: {listCount} times");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Thank you so much! Come again soon!! ^O^");
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("Invalid input. Please choose from 1 to 4. :D ");
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("");
                    break;
            }
        }
    }
}