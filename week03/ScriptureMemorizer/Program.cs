using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("");

        Reference refer;
        Scripture scripture;

        string name; string input;
        int chapter; int verse; int? endVerse;
        string excerpt = "";

        while (true)
        {
            Console.WriteLine("--------------- Welcome to Scripture Memorizer ---------------"); 
            Console.WriteLine("Please enter the scripture reference, followed by the verse you would like to memorize ^_^");
            Console.WriteLine("");

            Console.Write("> Book Name: ");
            name = Console.ReadLine().Trim();
            Console.Write("> Chapter Number: ");
            chapter = int.Parse(Console.ReadLine().Trim());
            Console.Write("> Verse(s) Number: ");

            input = Console.ReadLine().Trim();
            if (input.Contains('-') && input.Any(char.IsDigit))
            {
                string[] temp = input.Split("-");
                verse = int.Parse(temp[0]);
                endVerse = int.Parse(temp[1]);
                refer = new Reference(name, chapter, verse, endVerse);
                for (int num = verse; num <= endVerse; num++)
                {
                    Console.Write($"> Please enter verse {num}'s text: ");
                    excerpt += Console.ReadLine() + '\n';
                }
            }
            else
            {
                verse = int.Parse(input);
                refer = new Reference(name, chapter, verse);
                Console.Write($"> Please enter verse {verse}'s text: ");
                excerpt = Console.ReadLine() + '\n';
            }
            scripture = new Scripture(refer, excerpt);
            while (true)
            {
                scripture.Display();
                Console.Write("\n> Please type QUIT to exit or press enter to continue memorizing: ");
                input = Console.ReadLine();
                if (input.ToUpper() == "QUIT" || scripture.AreWordsHidden())
                {
                    Console.Write("----- Thank you for using my Scripture Memorizer! Until next time ^^ -----");
                    return;
                }
                scripture.HideWords();
            }

        }
    }
}