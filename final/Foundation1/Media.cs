using System;
namespace Foundation1;

    abstract class Media{
    public string Title { get; set; }
    public string Author { get; set; }

    public Media(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public abstract void DisplayInfo();
    public abstract int GetNumComments();    
}
