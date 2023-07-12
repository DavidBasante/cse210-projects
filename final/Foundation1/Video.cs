using System;
using System.Collections.Generic;
namespace Foundation1;


class Video : Media
{
    public int Length { get; set; }
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int length) : base(title, author)
    {
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenter, string text)
    {
        Comment comment = new Comment(commenter, text);
        Comments.Add(comment);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Length: " + Length + " seconds");
        Console.WriteLine("Number of comments: " + GetNumComments());
        Console.WriteLine("Comments:");
        foreach (Comment comment in Comments)
        {
            Console.WriteLine("  Commenter: " + comment.Commenter);
            Console.WriteLine("  Comment: " + comment.Text);
            Console.WriteLine();
        }
    }

    public override int GetNumComments()
    {
        return Comments.Count;
    }
}