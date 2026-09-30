class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video(
            "Learning C# for Beginners",
            "Programming Academy",
            420);

        video1.AddComment(new Comment(
            "John",
            "This tutorial helped me understand C# better."));

        video1.AddComment(new Comment(
            "Sarah",
            "Very clear and easy to follow."));

        video1.AddComment(new Comment(
            "David",
            "I learned a lot from this video."));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video(
            "Introduction to Web Development",
            "Code World",
            560);

        video2.AddComment(new Comment(
            "Michael",
            "Great explanation of web development."));

        video2.AddComment(new Comment(
            "Grace",
            "I really enjoyed this tutorial."));

        video2.AddComment(new Comment(
            "Daniel",
            "The examples were very helpful."));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video(
            "How to Build Your First Website",
            "Tech Tutorials",
            735);

        video3.AddComment(new Comment(
            "Peter",
            "This was exactly what I needed."));

        video3.AddComment(new Comment(
            "Alice",
            "The steps were easy to understand."));

        video3.AddComment(new Comment(
            "James",
            "Thank you for sharing this tutorial."));

        videos.Add(video3);

        // Display all videos and their comments
        Console.WriteLine("YouTube Videos and Comments");
        Console.WriteLine("==========================");
        Console.WriteLine();

        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}