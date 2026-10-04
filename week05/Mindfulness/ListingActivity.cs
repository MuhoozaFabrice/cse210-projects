using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _responses;
    private Random _random;

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        )
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _responses = new List<string>();
        _random = new Random();
    }

    public void Run()
    {
        StartActivity();

        Console.WriteLine("Think about the following prompt:");
        Console.WriteLine();

        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        Console.WriteLine("You will have a few seconds to prepare.");
        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine("Start listing your responses.");
        Console.Write("> ");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                _responses.Add(response);
            }

            if (DateTime.Now >= endTime)
            {
                break;
            }

            Console.Write("> ");
        }

        Console.WriteLine();
        Console.WriteLine(
            $"You listed {_responses.Count} items."
        );

        EndActivity();
    }
}