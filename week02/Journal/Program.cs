using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        string[] prompts =
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one thing I learned today?",
            "What is one thing I am grateful for today?"
        };

        Random random = new Random();

        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Search journal");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1)
            {
                string prompt = prompts[random.Next(prompts.Length)];

                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Response: ");
                string response = Console.ReadLine();

                Console.Write("How are you feeling today? ");
                string mood = Console.ReadLine();

                string date = DateTime.Now.ToString("MMMM dd, yyyy");

                Entry entry = new Entry();

                entry._date = date;
                entry._prompt = prompt;
                entry._response = response;
                entry._mood = mood;

                journal.AddEntry(entry);

                Console.WriteLine("Your entry has been saved.");
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename: ");
                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);
            }
            else if (choice == 4)
            {
                Console.Write("Enter the filename: ");
                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);
            }
            else if (choice == 5)
            {
                Console.Write("Enter a word to search for: ");
                string searchWord = Console.ReadLine().ToLower();

                bool found = false;

                foreach (Entry entry in journal._entries)
                {
                    if (entry._response.ToLower().Contains(searchWord))
                    {
                        entry.Display();
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("No matching entries were found.");
                }
            }
            else if (choice == 6)
            {
                Console.WriteLine("Thank you for using the Journal Program!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1-6.");
            }
        }

    }
}