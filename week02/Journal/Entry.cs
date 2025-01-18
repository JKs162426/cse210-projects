using System.Data.Common;
using System.Net.Mail;

public class Entry
{
    public string _prompt;
    public string _journalEntryText;
    public DateTime _journalEntryTimeStamp;

    public void Display()
    {   
        string formattedDate = _journalEntryTimeStamp.ToShortDateString();
        Console.WriteLine($"Date: {formattedDate} - Prompt {_prompt} {_journalEntryText}");
    }
}