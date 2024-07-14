
class Program
{
    static void Main()
    {
        // Create some videos
        var video1 = new Video("Introduction to Python", "John Doe", 600);
        var video2 = new Video("Advanced Python Techniques", "Jane Smith", 1200);
        var video3 = new Video("Python for Data Science", "Emily White", 1800);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great introduction!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "Excellent explanation of advanced concepts."));
        video2.AddComment(new Comment("Eve", "Could you cover more on generators?"));
        video2.AddComment(new Comment("Frank", "Well presented!"));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Perfect for beginners in data science."));
        video3.AddComment(new Comment("Hank", "The examples were really useful."));
        video3.AddComment(new Comment("Ivy", "Looking forward to more videos like this."));

        // Put videos in a list
        var videos = new List<Video> { video1, video2, video3 };

        // Iterate through the list of videos and display their information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}