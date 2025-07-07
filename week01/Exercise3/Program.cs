using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("I have selected a magic number between 1 and 100.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;;

        while (guess != magicNumber)
        {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher!");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower...");
            }
            else
            {
                Console.WriteLine("WOAH, You guessed it! Maybe you are a wizard?");
            }

        }
    }
}