using System;
using System.Collections.Generic;

public class Video 
{
    private string _author;
    private string _title;
    private int _duration;
    private List<Comment> _commentList = new List<Comment>();


    public Video(string title, string author, int duration)
    {
        _author = author;
        _title = title;
        _duration = duration;
    }

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }

    public int GetCountCommentList()
    {
        return _commentList.Count;
    }

    public void DisplayVideo()
    {       
            int index = 1;
            Console.WriteLine($"\nVideo: {_title} by {_author}");
            Console.WriteLine($"Duration: {_duration} seconds");
            Console.WriteLine($"Number of comments: {GetCountCommentList()}");
            Console.WriteLine($"Comments:");

            foreach(var comment in _commentList)
            {
                Console.Write($"{index}. ");
                comment.DisplayComment();
                index ++;
            }
    }
}