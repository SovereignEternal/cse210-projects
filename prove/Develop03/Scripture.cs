/*
Reference
---------
States:
Reference : _reference
List<Word> : _words
Random : _random
Behaviors:
void : DisplayScripture()
void : HideWords()
bool : AllHidden()
*/
using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] parts = text.Split(' ');

        for (int i = 0; i < parts.Length; i++)
        {
            Word w = new Word(parts[i]);
            _words.Add(w);
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetReference());

        for (int i = 0; i < _words.Count; i++)
        {
            string text = _words[i].GetText();
            Console.Write(text + " ");
        }

        Console.WriteLine();
    }

    public void HideWords()
    {
        int hiddenCount = 0;

        while (hiddenCount < 2)
        {
            int index = _random.Next(_words.Count);

            if (_words[index].IsHidden() == false)
            {
                _words[index].HideWord();
                hiddenCount = hiddenCount + 1;
            }
        }
    }

    public bool AllHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
}