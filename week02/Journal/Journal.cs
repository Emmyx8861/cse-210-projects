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

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string file)
{
    using (StreamWriter writer = new StreamWriter(file))
    {
        foreach (Entry entry in _entries)
        {
            writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
        }
    }
}

   public void LoadFromFile(string file)
{
    string[] lines = System.IO.File.ReadAllLines(file);

    foreach (string line in lines)
    {
        if (string.IsNullOrWhiteSpace(line))
        {
            continue;
        }

        string[] parts = line.Split(",");

        if (parts.Length < 3)
        {
            continue;
        }

        string datePart = parts[0];
        string promptPart = parts[1];
        string entryPart = parts[2];

        Entry newEntry = new Entry();
        newEntry._date = datePart;
        newEntry._promptText = promptPart;
        newEntry._entryText = entryPart;

        _entries.Add(newEntry);
    }}

    public int CalculateStreak()
{
    if (_entries.Count == 0)
    {
        return 0;
    }

    HashSet<string> uniqueDates = new HashSet<string>();
    foreach (Entry entry in _entries)
    {
        uniqueDates.Add(entry._date);
    }

    int streak = 0;
    DateTime checkDate = DateTime.Today;

    if (!uniqueDates.Contains(checkDate.ToShortDateString()))
    {
        checkDate = checkDate.AddDays(-1);
    }

    while (uniqueDates.Contains(checkDate.ToShortDateString()))
    {
        streak++;
        checkDate = checkDate.AddDays(-1);
    }

    return streak;
}
}
        
      


