using System.Data;
using System.IO;
using System.IO.Enumeration;
using System.Collections.Generic;

public class Journal 
{
    List<Entry> _entryList = new List<Entry>();

    public void DisplayOptionsMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");
    }

    public void AddEntry(string prompt, string journalEntryText)
    {
        Entry entryText = new Entry();
        entryText._prompt = prompt;
        entryText._journalEntryText = journalEntryText;
        entryText._journalEntryTimeStamp = DateTime.Now;
        _entryList.Add(entryText);
    }

    public void SaveEntry(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entryList)
            {
                writer.WriteLine($"{entry._journalEntryTimeStamp};{entry._prompt};{entry._journalEntryText}");
            }
        }
        Console.WriteLine($"Journal saved to {fileName}");
    }

    public void LoadEntry(string fileName)
    {
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            _entryList.Clear();
            foreach (var line in lines)
            {
                var parts = line.Split(";");
                if (parts.Length == 3)
                {
                     _entryList.Add(new Entry
                {
                    _prompt = parts[1].Trim(),
                    _journalEntryText = parts[2].Trim(),
                    _journalEntryTimeStamp = DateTime.Parse(parts[0].Trim())
                });
                }
            }
            Console.WriteLine($"Journal loaded from {fileName}");
            DisplayEntries();
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }

    public void DisplayEntries()
    {
        if (_entryList.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            foreach (var entry in _entryList)
            {
                entry.Display();
            }
        }
    }
}