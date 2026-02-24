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
        "How did I help someone today?",
        "What could I have done better today?",
        "What was the highlight of my day?",
        "How have I improved my relationship with God today?",
        "What is the hardest thing I did today?",
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