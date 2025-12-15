using System;
using System.Collections.Generic;

// Comment class
class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

// Video class
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; } = new();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");

        foreach (var comment in Comments)
            Console.WriteLine($"- {comment.Name}: {comment.Text}");

        Console.WriteLine("-----------------------------------");
    }
}

// Main program
class VideoProgram
{
    static void Main()
    {
        List<Video> videos = new();

        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        video1.Comments.Add(new Comment("Alice", "Great explanation!"));
        video1.Comments.Add(new Comment("Bob", "Very helpful!"));

        Video video2 = new Video("OOP in C#", "Jane Smith", 450);
        video2.Comments.Add(new Comment("Emma", "Loved it!"));

        videos.Add(video1);
        videos.Add(video2);

        foreach (var video in videos)
            video.DisplayVideoInfo();

        // Prevent console from closing immediately
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
