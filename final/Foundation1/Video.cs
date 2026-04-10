using System;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _length = videoLength;
    }

    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name,text));
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length in Seconds: {_length}");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");

        PrintAllComments();
        Console.WriteLine();
    }

    public void PrintAllComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.PrintComment();
        }
    }

}