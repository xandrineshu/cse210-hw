using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise 1 Project.");

        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}



/* notes:

if write "Console.WriteLine"
outcome will be in a new line

if write "Console.Write"
outcome will be in the same line
.
.
.


From the video execise:

Console.WriteLine("Hello World! This is the Exercise1 Project.");
Console.WriteLine("This project is part of the Week 01 exercises.");

Console.Write("What is your favorite color? ");
string color = Console.ReadLine(); 
Console.WriteLine($"Your favorite color is {color}. Me too! ^^");


 */
