using System;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity() : base()
    {
        SetActivityName("Reflection Activity");
        SetActivityDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        _prompts = new List<string>
        {
            //10 prompts
            "--- Think of a time when you stood up for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a time when you did something truly selfless. ---",
            "--- Think of a time when you you stepped outside of your comfort zone. ---",
            "--- Think of a time you experienced joy. ---",
            "--- Think of a time wen you felt grateful. ---",
            "--- Think of a time you were particularly proud of yourself. ---",
            "--- Think of a time when you learned a valuable lesson. ---",
            "--- Think of a time you felt a strong sense of purpose. ---"
        };

        _questions = new List<string>
        {
            //10 self-reflecting questions
            "Why was this experience meaningful to you? ",
            "Have you ever done anything like this before? ",
            "How did you get started? ",
            "How did you feel when it was complete? ",
            "What made this time different than other times when you were not as successful? ",
            "What is your favorite thing about this experience? ",
            "What could you learn from this experience that applies to other situations? ",
            "What did you learn about yourself through this experience? ",
            "How can you keep this experience in mind in the future? ",
            "How did you feel about yourself after this experince? "
        };
    }

    public void RunReflectingActivity()
    {
        RunActivityParentStart();
        DisplayPrompt();
        DisplayQuestions();
        RunActivityParentEnd();
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following: ");
        Console.WriteLine();

        int randomIndex = new Random().Next(0, _prompts.Count());
        Console.WriteLine(_prompts[randomIndex]);
        Console.WriteLine();

        Console.Write("When you have something in mind, press enter to continue ");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        List<int> indexes = new List<int>();

        for (int i = 0; i < 4; i++)
        {
            int randomInt = new Random().Next(0, _questions.Count());
            while (indexes.Contains(randomInt))
            {
                randomInt = new Random().Next(0, _questions.Count());
            }
            indexes.Add(randomInt);
        }

        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience. U_U ");
        Console.WriteLine();
        DisplayCountdown(5);

        foreach (int index in indexes)
        {
            Console.Write(_questions[index]);
            DisplaySpinner((GetUserSessionLengthInput() / indexes.Count()));
            Console.WriteLine();
        }
    }
}