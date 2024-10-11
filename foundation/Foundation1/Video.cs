
using System;
public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments on the video
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetVideoDetails()
    {
        return $"Title: {_title}\nAuthor: {_author}\nLength: {_lengthInSeconds} seconds\nNumber of comments: {GetNumberOfComments()}";
    }

    // Method to display all comments on the video
    public void DisplayComments()
    {
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetCommentDetails());
        }
    }
}