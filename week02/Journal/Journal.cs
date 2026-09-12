using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(
                    $"{entry._date}|{entry._prompt}|{entry._response}|{entry._mood}"
                );
            }
        }

        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            entry._mood = parts[3];

            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded successfully.");
    }
}