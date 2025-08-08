using System;

class Program
{
    static void Main(string[] args)
    {
        AllGoals allGoals = new AllGoals();
        int userMainMenuSelection = 0;

        Console.Clear();
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.WriteLine();
        Console.WriteLine("============== Welcome to the Goal Tracking App ==============");

        while (userMainMenuSelection != 6)
        {
            Menu menu = new Menu();
            allGoals.DisplayPoints(allGoals.getTotalPoints());
            Console.WriteLine();
            menu.DisplayMainMenu();
            userMainMenuSelection = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userMainMenuSelection)
            {
                case 1:
                    menu.DisplayNewGoalMenu();
                    int userNewGoalSelection = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Goal goal = null;

                    if (userNewGoalSelection == 1)
                    {
                        goal = new SimpleGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }

                    else if (userNewGoalSelection == 2)
                    {
                        goal = new EternalGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }

                    else
                    {
                        goal = new CheckListGoal();
                        goal.DisplayGoalName();
                        goal.DisplayGoalDescription();
                        goal.DisplayGoalPoints();
                    }

                    if (goal != null)
                    {
                        allGoals.addGoal(goal);
                    }
                    break;

                case 2:
                    allGoals.DisplayGoals();
                    break;

                case 3:
                    allGoals.SaveGoals();
                    break;

                case 4:
                    allGoals.LoadGoals();
                    break;

                case 5:
                    allGoals.DisplayGoalRecordEvent();
                    break;

                case 6:
                    Console.Write("Do you want to save before you quit (Yes/No)? ");
                    string userInput = Console.ReadLine();

                    if (userInput == "Yes")
                    {
                        allGoals.SaveGoals();
                    }

                    if (userInput == "No")
                    {
                        Console.WriteLine("Aww, that's a shame. They will not be saved :(");
                        Console.WriteLine();
                    }

                    Console.WriteLine("Thank you for using the Goal Tracking App! Come again soon! :3");
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Please select a valid option...");
                    break;

            }
        }
    }
}
