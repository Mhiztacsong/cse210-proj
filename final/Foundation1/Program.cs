using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some video instances
            Video video1 = new Video("Learning C#", "Alice", 300);
            Video video2 = new Video("Cooking 101", "Bob", 600);
            Video video3 = new Video("Travel Vlog", "Charlie", 900);

            // Add comments to the videos
            video1.AddComment(new Comment("User1", "Great tutorial!"));
            video1.AddComment(new Comment("User2", "Very helpful, thanks!"));
            video1.AddComment(new Comment("User3", "Loved it!"));

            video2.AddComment(new Comment("User4", "Nice recipe!"));
            video2.AddComment(new Comment("User5", "Can't wait to try this out."));
            video2.AddComment(new Comment("User6", "Looks delicious!"));

            video3.AddComment(new Comment("User7", "Amazing places!"));
            video3.AddComment(new Comment("User8", "Where was this filmed?"));
            video3.AddComment(new Comment("User9", "Great video quality."));

            // Store the videos in a list
            List<Video> videos = new List<Video> { video1, video2, video3 };

            // Iterate through the list of videos and display their details
            foreach (Video video in videos)
            {
                Console.WriteLine(video);
                Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
                foreach (Comment comment in video._comments)
                {
                    Console.WriteLine(comment);
                }
                Console.WriteLine("--------------------------------------------------");
            }
    }
}