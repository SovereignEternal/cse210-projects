using System;
/*
string _timestamp
string _prompt
string _entryText

Entry NewEntry()
string EntryTextToFile()
void GeneratePrompt()
void SetDate()
*/
class Entry
{
    private DateTime currentTime = DateTime.Now;
    private string _date;
    private string _prompt;
    private string _entryText;
    private static Random _random = new Random();
    List<string> _prompts = new List<string>
    {
        "Prompt 1 text",
        "Prompt 2 text",
        "Prompt 3 text",
        "Prompt 4 text",
        "Prompt 5 text",
    };
    
    private void GeneratePrompt()
    {
        int randomInt = _random.Next(_prompts.Count);
        _prompt = _prompts[randomInt];
    }
    
    private void SetDate()
    {
        _date = currentTime.ToShortDateString();
    }

    public void DisplayEntry()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine(_entryText);
    }

    public static Entry EntryFromText(string line)
    {
        string[] parts = line.Split('|');
        
        Entry entry = new Entry();

        entry._date = parts[0];
        entry._prompt = parts[1];
        entry._entryText = parts[2];

        return entry;
    }
    
    public string EntryTextToFile()
    {
        return $"{_date}|{_prompt}|{_entryText}";
    }

    public void CreateEntry()
    {
        GeneratePrompt();
        Console.WriteLine(_prompt);
        _entryText = Console.ReadLine();
        SetDate();
    }
}