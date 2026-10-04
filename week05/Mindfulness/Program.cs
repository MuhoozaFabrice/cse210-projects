using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Creativity and exceeding requirements:
        // In addition to the three required activities, this program keeps
        // track of how many times each activity is completed during the
        // current session. The statistics are displayed when the user quits.

        int breathingCount = 0;
        int listingCount = 0;
        int reflectingCount = 0;

        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("===================");
            Console.WriteLine();
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity =
                        new BreathingActivity();

                    breathingActivity.Run();
                    breathingCount++;

                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.ReadLine();
                    break;

                case "2":
                    ReflectingActivity reflectingActivity =
                        new ReflectingActivity();

                    reflectingActivity.Run();
                    reflectingCount++;

                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.ReadLine();
                    break;

                case "3":
                    ListingActivity listingActivity =
                        new ListingActivity();

                    listingActivity.Run();
                    listingCount++;

                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.ReadLine();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine(
                        "Invalid choice. Please select 1, 2, 3, or 4."
                    );

                    Thread.Sleep(1500);
                    break;
            }
        }

        Console.Clear();

        Console.WriteLine("Thank you for using the Mindfulness Program!");
        Console.WriteLine();
        Console.WriteLine("Session Statistics");
        Console.WriteLine("------------------");
        Console.WriteLine(
            $"Breathing activities completed: {breathingCount}"
        );
        Console.WriteLine(
            $"Reflecting activities completed: {reflectingCount}"
        );
        Console.WriteLine(
            $"Listing activities completed: {listingCount}"
        );
        Console.WriteLine();

        Console.WriteLine("Goodbye!");
    }
}