using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Abstraction Explained","Programming How-To",450);
        Video video2 = new Video("Flashpoint Update","Arc Raiders",600);
        Video video3 = new Video("The Most Insane Megaproject You Never Heard About","Kurzgesagt - In a Nutshell",786);

        video1.AddComment("John","Great explanation!");
        video1.AddComment("Martha","I'm an elementary school teacher... why am I here?");
        video1.AddComment("Davis","Good stuff.");

        video2.AddComment("Joseph","Great game, excited for the new event!");
        video2.AddComment("James","Can you do something about the rats?");
        video2.AddComment("Charlie","Never playing this game again.");

        video3.AddComment("Kate","Y'all come up with the wildest stuff.");
        video3.AddComment("Matthew","Loved this, thanks.");
        video3.AddComment("Mark","I could make it work.");

        List<Video> videos = new List<Video> {video1,video2,video3};

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}