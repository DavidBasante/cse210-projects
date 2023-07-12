using System;
namespace Foundation1;
class Program
{
    static void Main(string[] args)
    {
        List<Media> mediaList = new List<Media>();

        Video video1 = new Video("Video Title 1", "Author 1", 120);
        video1.AddComment("Commenter 1", "Comment 1");
        video1.AddComment("Commenter 2", "Comment 2");
        mediaList.Add(video1);

        Video video2 = new Video("Video Title 2", "Author 2", 180);
        video2.AddComment("Commenter 1", "Comment 1");
        video2.AddComment("Commenter 2", "Comment 2");
        video2.AddComment("Commenter 3", "Comment 3");
        mediaList.Add(video2);

        foreach (Media media in mediaList)
        {
            media.DisplayInfo();
            Console.WriteLine();
        }
    }

}
