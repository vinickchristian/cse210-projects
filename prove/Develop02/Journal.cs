using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries;
    public PromptGenerator promptGenerator; 

    public Journal()
    {
        promptGenerator = new PromptGenerator();
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile(string file)
    {
        try
        {

            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    // Save date, prompt, and entry text separated by ','
                    outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
                }
                Console.WriteLine($"Journal entries saved to {file}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving entries to {file}: {e.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
        try
        {
            string[] lines = File.ReadAllLines(file);
            _entries.Clear();  // Clear existing entries before loading new ones

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[1], parts[2], parts[0]));
                }
            }

            Console.WriteLine($"Journal successfully loaded from {file}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the journal: {ex.Message}");
        }
    }
}