using System;
using System.Collections.Generic;
class Scripture
{
    private Reference _reference;

    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach(string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();

        foreach( Word word in _words)
        {
            referenceText += " " + word.GetDisplayText();
        }
        return referenceText;
        
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public int GetVisibleWordCount()
    {
        int count = 0;

        foreach (Word word in _words)
            {
            if (!word.IsHidden())
                {
                    count++;
                }
            }

        return count;
    }
}