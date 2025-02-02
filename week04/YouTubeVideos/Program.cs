using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video1 = new Video("Best goals in UEFA Champiopns League History", "ESPN", 540);
        Video video2 = new Video("Legendary Knockouts in Boxing", "HBO Sports", 720);
        Video video3 = new Video("Most Epic Moments in Formula 1", "F1 Official", 900);

        video1.AddComment(new Comment("Carlos", "Messi's goal was unbelievable!"));
        video1.AddComment(new Comment("Anna", "Cristiano Ronaldo's bicycle kick is the best."));
        video1.AddComment(new Comment("Peter", "I love long-range goals."));

        video2.AddComment(new Comment("Luis", "Tyson's KO is still brutal."));
        video2.AddComment(new Comment("George", "Mayweather was not a knockout artist, but his technique was incredible."));
        video2.AddComment(new Comment("Maria", "Ali ws a genius in the ring, such great fights."));

        video3.AddComment(new Comment("Diego", "That overtake by Senna was historic"));
        video3.AddComment(new Comment("Sonia", "Schumacher had incredible control of the car."));
        video3.AddComment(new Comment("Andrew", "Watching Verstappen's comeback is impressive."));

        video1.DisplayVideo();
        video2.DisplayVideo();
        video3.DisplayVideo();

    }
}