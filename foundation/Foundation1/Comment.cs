using System;
using System.Collections.Generic;

public class Comment
{
    // Private fields to encapsulate commenter's name and comment text
    private string _commenterName;
    private string _commentText;

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Method to return the comment details as a string
    public string GetCommentDetails()
    {
        return $"{_commenterName}: {_commentText}";
    }
}