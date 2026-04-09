/*
Reference
---------
States:
string : _text
bool : _Hidden
Behaviors:
void : HideWord()
bool : IsHidden()
string : GetText()
*/
using System;

class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void HideWord()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetText()
    {
        if (_hidden == true)
        {
            string displayText = "";

            for (int i = 0; i < _text.Length; i++)
            {
                displayText = displayText + "_";
            }

            return displayText;
        }
        else
        {
            return _text;
        }
    }
}