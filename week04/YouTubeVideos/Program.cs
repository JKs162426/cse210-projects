using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.Clear();

        List<Video> videos = new List<Video>();


        Video video1 = new Video("Funny Cats", "Animals LOL", 930);
        video1.AddComment(new Comment("Kley","Hahahaha 🤣😂🤣"));
        video1.AddComment(new Comment("Katherine", "I need to record my cat!"));
        video1.AddComment(new Comment("Kleber", "The first white cat is too similar to my Campanita."));
        videos.Add(video1);

        Video video2 = new Video("Why was Hashima abandoned?", "Un Mundo Inmenso", 596);
        video2.AddComment(new Comment("Jeronimo","Entré más rápido que tomarme un ferry a Tristán de Acuña"));
        video2.AddComment(new Comment("Isaac", "Excelente como siempre ❤️"));
        video2.AddComment(new Comment("Jesus", "Hay un video de UMI = es un buen día"));
        videos.Add(video2);


        Video video3 = new Video("Deutsch lernen mit Videos | Familienalltag in Deutschland", "Deutsch lernen mit der DW", 316);
        video3.AddComment(new Comment("@rotblumen","Vielen Dank für Ihr Film"));
        video3.AddComment(new Comment("@Mohcine", "Schönes video ❤️❤️❤️"));
        video3.AddComment(new Comment("@Wirakoscha", "Angeblich ist Lena unsterblich, Sie trägt kein Helm auf."));
        videos.Add(video3);

        Video video4 = new Video("Germans Describe Their Profession | Easy German 556", "Easy German", 851);
        video4.AddComment(new Comment("Ameen Ali","4:42 subtitles were the only way I'd recognize/hear that 'beziehungsweise'."));
        video4.AddComment(new Comment("Amanda Fernandes", "Was für ein cooles Video! Ich bin Softwareentwickler, lebe in Brasilien und bin noch Anfänger in Deutsch."));
        video4.AddComment(new Comment("@cad6918", "Vielen vielen Dank für Ihre Mühe!  So ein schöner Programm!❤"));
        videos.Add(video4);
        
        foreach (var video in videos)
        {
            video.DisplayVideo();
        }
    }
}