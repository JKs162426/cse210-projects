using System;
using System.Collections.Generic;

public class Scripture
{
    Reference _reference = new Reference("John", 3, 16);
    List<Word> _words = new List<Word>();

    public Scripture()
    {   
        var text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomNumber()
    {
        Random random = new Random();
        int hiddenCount = 0;

        if (_words.Count(word => !word.IsHidden()) > 3)
        {
            while (hiddenCount < 3)
        {
            int index = random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
        }
        else
        {
            foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                word.Hide();
            }
        }
        }
    }

    public string GetDisplayText()
    {   
        string text = _reference.GetDisplayText();
        foreach (var word in _words)
        {
            text += " " + word.GetDisplayText();
        }
        return text.Trim();
    }

    public bool IsCompletelyHidden()
    {   
        return _words.All(word => word.IsHidden());
    }
}