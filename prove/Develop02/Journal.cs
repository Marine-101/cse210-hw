using System.Collections.Generic;
using System;
using System.IO;
public class Journal
{
    
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "Who did I talk to today?",
        "What is something new I learned today?",
        "What am I grateful for today?",
        "What is something I want to improve?",
        "What challenge did I overcome today?"
    };

    public List<Entry> _entries = new List<Entry>();

    public void DisplayALL()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Add_Entry()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        string prompt = _prompts[index];

        Console.WriteLine(prompt);
        string responce = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._prompt = prompt;
        newEntry._responce = responce;

        _entries.Add(newEntry);
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach ( Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._prompt}~|~{entry._responce}");
            }
        }

    }

    public void LoadFromFile()
    {
        Console.WriteLine("what is the filename?");
        string filename = Console.ReadLine();

        _entries.Clear();

        using (StreamReader inputFile = new StreamReader(filename))
        {
            string line = inputFile.ReadLine();

            while (line != null)
            {
                string[] parts = line.Split("~|~");
                Entry newEntry = new Entry();
                newEntry._date = parts[0];
                newEntry._prompt = parts[1];
                newEntry._responce = parts[2];

                _entries.Add(newEntry);

                line = inputFile.ReadLine();

                
            }

        }
    
    }

    public void SearchEntries()
    {
        Console.WriteLine("what word would you like to search for? ");
        string word = Console.ReadLine();

        bool found = false;
        foreach (Entry entry in _entries)
        {
            if (entry._prompt.Contains(word, StringComparison.OrdinalIgnoreCase))
            {
                entry.Display();
                found = true;
            }

            else if (entry._responce.Contains(word, StringComparison.OrdinalIgnoreCase))
            {
                entry.Display();
                found = true;
            }

            else
            {
                
            }
        }

    if (found == false)
        {
            Console.WriteLine("sorry I could'nt find thw word :( ");
        }   
    }

}