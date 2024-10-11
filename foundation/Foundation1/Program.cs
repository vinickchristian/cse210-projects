using System;

class Program
{
    static void Main(string[] args)
    {
         // Create video objects
        Video video1 = new Video("Learn C# in One Hour", "Programming Guru", 3600);
        Video video2 = new Video("Top 10 Gadgets 2024", "Tech Reviews", 600);
        Video video3 = new Video("How to Cook Pasta", "Chef's Corner", 900);

        // Add comments to video1
        video1.AddComment(new Comment("John", "Great tutorial, really helpful!"));
        video1.AddComment(new Comment("Jane", "I loved how everything was explained clearly."));
        video1.AddComment(new Comment("Mike", "Could you cover more advanced topics next time?"));

        // Add comments to video2
        video2.AddComment(new Comment("Alice", "Can't wait to try some of these gadgets."));
        video2.AddComment(new Comment("Bob", "Nice video, very informative."));
        video2.AddComment(new Comment("Charlie", "Would love to see more reviews like this!"));

        // Add comments to video3
        video3.AddComment(new Comment("David", "I tried this recipe and it was amazing!"));
        video3.AddComment(new Comment("Emma", "Simple and easy to follow."));
        video3.AddComment(new Comment("Sophia", "Thanks for the cooking tips!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display details of each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetVideoDetails());
            video.DisplayComments();
            Console.WriteLine(); 
        }
    }
}