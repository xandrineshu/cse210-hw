using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise 2 Project.");

        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed! Hooray!!");
        }
        else
        {
            Console.WriteLine("Better luck next time! Keep trying!");
        }
    }
}

/* notes:

== means equal to
!= means not equal to
> means greater than
< means less than
>= means greater than or equal to
<= means less than or equal to
&& means logical AND
|| means logical OR


----------------

Video Exercise:


    Console.Write("Enter a number: ");
    string valueFromUser = Console.ReadLine();

    int x = int.Parse(valueFromUser);
    int y = 2;

    if (x > y)
    {         Console.WriteLine("Your number is greater than 2.");
    
    }

    else if (x < y)
    {
        Console.WriteLine("Your number is less than 2.");
    }

    else
    {
            Console.WriteLine("Your number is equal to 2.");
    }

*/