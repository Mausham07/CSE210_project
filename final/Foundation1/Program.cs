using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Introduction to Programming", "John Doe", 300);
        video1.AddComment("Alice", "Great video!");
        video1.AddComment("Bob", "I learned a lot.");

        Video video2 = new Video("Data Structures Explained", "Jane Smith", 450);
        video2.AddComment("Charlie", "Very informative!");
        video2.AddComment("David", "Could you provide more examples?");

        Video video3 = new Video("C# Programming Tutorial", "Chris Evans", 600);
        video3.AddComment("Emma", "Awesome tutorial!");
        video3.AddComment("Frank", "I have a question.");

        // Adding videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying information for each video
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}