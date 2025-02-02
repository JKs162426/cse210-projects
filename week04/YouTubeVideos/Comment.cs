using System;

public class Comment
{
    string _author;
    string _commentText;

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