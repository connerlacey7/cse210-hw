class Video
{
    private List<Comment> _comments;

    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of comments: {NumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"  {comment}");
        }
        Console.WriteLine(); // Add an empty line for better readability
    }
}