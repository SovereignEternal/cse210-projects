using System;
using System.IO.Enumeration;
/*
List<Entry> Entries
string _fileName

SaveToFile()
LoadFromFile()
DisplayEntries()
AddEntry()
*/
class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void SaveToFile()
    {
        Console.Write("Enter desired FileName in format \"filename.txt\": ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.EntryTextToFile());
            }
        }
    }

    public void LoadFromFile()
    {
        Console.Write("Enter desired FileName to open (\"filename.txt\"): ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _entries.Clear();

        foreach (string line in lines)
        {
            _entries.Add(Entry.EntryFromText(line));
        }
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.CreateEntry();
        _entries.Add(entry);
    }
}