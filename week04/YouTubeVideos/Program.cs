using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video objects
        Video video1 = new Video("C# Basics", "John Smith", 600);
        Video video2 = new Video("Advanced OOP", "Jane Doe", 900);
        Video video3 = new Video("Design Patterns", "Mike Johnson", 1200);
        Video video4 = new Video("Web Development", "Sarah Williams", 1500);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks"));
        video1.AddComment(new Comment("Charlie", "Need more examples"));

        // Add comments to video 2
        video2.AddComment(new Comment("Alice", "Excellent explanation"));
        video2.AddComment(new Comment("David", "Could be clearer"));
        video2.AddComment(new Comment("Emma", "Loved this!"));
        video2.AddComment(new Comment("Frank", "Perfect, just what I needed"));

        // Add comments to video 3
        video3.AddComment(new Comment("Grace", "Amazing content"));
        video3.AddComment(new Comment("Henry", "Very informative"));

        // Add comments to video 4
        video4.AddComment(new Comment("Ivy", "Best video yet"));
        video4.AddComment(new Comment("Jack", "Outstanding work"));
        video4.AddComment(new Comment("Karen", "Learned so much"));
        video4.AddComment(new Comment("Leo", "Highly recommend"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display all video details
        Console.Clear();
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}