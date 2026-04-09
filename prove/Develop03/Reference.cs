/*
Reference
---------
States:
string : _book
int : _chapter
int : _verseStart
int : _verseEnd
bool : _multiVerse
Behaviors:
string : GetReference
*/

using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    private bool _multiVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _multiVerse = false;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
        _multiVerse = true;
    }

    public string GetReference()
    {
        if (_multiVerse == true)
        {
            return _book + " " + _chapter + ":" + _verseStart + "-" + _verseEnd;
        }
        else
        {
            return _book + " " + _chapter + ":" + _verseStart;
        }
    }
}