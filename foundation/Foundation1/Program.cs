using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create video instances
        var video1 = new Video("Whole Lotta Love", "Led Zeppelin", 233);
        video1.AddComment(new Comment("John", "Great song!"));
        video1.AddComment(new Comment("Paul", "Classic rock at its best."));
        video1.AddComment(new Comment("George", "Love the guitar solo."));

        var video2 = new Video("Rock Playlist", "Various Artists", 3600);
        video2.AddComment(new Comment("Ringo", "This playlist rocks!"));
        video2.AddComment(new Comment("Mick", "Perfect for a party."));
        video2.AddComment(new Comment("Keith", "Great selection of tracks."));

        var video3 = new Video("Bohemian Rhapsody", "Queen", 354);
        video3.AddComment(new Comment("Freddie", "Is this the real life?"));
        video3.AddComment(new Comment("Brian", "One of the best songs ever."));
        video3.AddComment(new Comment("Roger", "Amazing vocal performance."));

        // Add videos to the list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine("Program YouTube Video Track");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}