List<Video> videos = new List<Video>();

Video video1 = new Video("Learning C# Basics", "John Smith", 600);
video1.AddComment(new Comment("Maria", "This video was very helpful."));
video1.AddComment(new Comment("David", "Great explanation!"));
video1.AddComment(new Comment("Anna", "I learned a lot from this video."));
videos.Add(video1);

Video video2 = new Video("Easy Pasta Recipe", "Cooking Time", 420);
video2.AddComment(new Comment("Carlos", "I will try this recipe."));
video2.AddComment(new Comment("Sofia", "It looks delicious!"));
video2.AddComment(new Comment("Emma", "Very easy to follow."));
videos.Add(video2);

Video video3 = new Video("Travel in Italy", "World Traveler", 780);
video3.AddComment(new Comment("Lucas", "Italy is beautiful."));
video3.AddComment(new Comment("Daniel", "I want to visit someday."));
video3.AddComment(new Comment("Laura", "Thanks for sharing!"));
videos.Add(video3);

foreach (Video video in videos)
{
    Console.WriteLine($"Title: {video.GetTitle()}");
    Console.WriteLine($"Author: {video.GetAuthor()}");
    Console.WriteLine($"Length: {video.GetLength()} seconds");
    Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
    Console.WriteLine("Comments:");

    foreach (Comment comment in video.GetComments())
    {
        Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
    }

    Console.WriteLine();
}