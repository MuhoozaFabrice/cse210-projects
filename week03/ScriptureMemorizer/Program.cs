using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text =
            "Trust in the Lord with all your heart and lean not on your own understanding " +
            "in all your ways submit to him and he will make your paths straight";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        /*
         * CREATIVITY / EXCEEDING REQUIREMENTS:
         *
         * In addition to the core requirements, this program hides
         * three random words at a time and prevents already hidden
         * words from being selected when possible. This makes the
         * memorization process more useful because each press of
         * Enter reveals fewer words until the entire scripture is hidden.
         */
    }
}