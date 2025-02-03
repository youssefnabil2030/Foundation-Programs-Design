using System;
using System.Collections.Generic;

// Comment Class to store comment details
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

// Video Class to store video details and comments
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // in seconds
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Method to return the number of comments
    public int GetCommentCount()
    {
        return Comments.Count;
    }

    // Method to display video details
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\nComments ({GetCommentCount()}):");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine("-----------------------------------");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Creating videos
        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        video1.Comments.Add(new Comment("Alice", "Great explanation!"));
        video1.Comments.Add(new Comment("Bob", "Very helpful, thanks!"));
        video1.Comments.Add(new Comment("Charlie", "I love this tutorial!"));

        Video video2 = new Video("OOP in C#", "Jane Smith", 450);
        video2.Comments.Add(new Comment("David", "This was so informative."));
        video2.Comments.Add(new Comment("Emma", "Helped me a lot!"));
        video2.Comments.Add(new Comment("Frank", "Best tutorial ever!"));

        Video video3 = new Video("Advanced C# Concepts", "Michael Brown", 600);
        video3.Comments.Add(new Comment("Grace", "Very detailed, thanks!"));
        video3.Comments.Add(new Comment("Hannah", "I learned so much!"));
        video3.Comments.Add(new Comment("Ian", "Fantastic content!"));

        // Adding videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Displaying each video's information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
