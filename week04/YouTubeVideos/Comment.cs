using System;

public class Comment
{
    private string _author;
    private string _commentText;

    public Comment(string author, string commentText)
    {
        _author = author;
        _commentText = commentText;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_author}: {_commentText}");
    }
}